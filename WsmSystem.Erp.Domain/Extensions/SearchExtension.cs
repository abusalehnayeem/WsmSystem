using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Reflection;

namespace WsmSystem.Erp.Domain.Extensions
{
    public static class SearchExtension
    {
        private static readonly MethodInfo LikeMethodInfo = typeof(DbFunctionsExtensions)
                .GetMethod(nameof(DbFunctionsExtensions.Like), new Type[] { typeof(DbFunctions), typeof(string), typeof(string) }) ?? throw new TargetException("The EF.Functions.Like not found");

        private static readonly MemberExpression Functions = Expression
            .Property(null, typeof(EF).GetProperty(nameof(EF.Functions)) ?? throw new TargetException("The EF.Functions not found!"));

        public static bool Like(this string input, string pattern)
        {
            try
            {
                return SqlLike(input, pattern);
            }
            catch (Exception)
            {
                throw new InvalidSearchPatternException(pattern);
            }
        }

        private static bool SqlLike(string str, string pattern)
        {
            bool isMatch = true, isWildCardOn = false, isCharWildCardOn = false, isCharSetOn = false, isNotCharSetOn = false;
            int lastWildCard = -1;
            int patternIndex = 0;
            var set = new List<char>();
            char p = '\0';
            bool endOfPattern = false;
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                endOfPattern = patternIndex >= pattern.Length;
                if (!endOfPattern)
                {
                    p = pattern[patternIndex];

                    if (!isWildCardOn && p == '%')
                    {
                        lastWildCard = patternIndex;
                        isWildCardOn = true;
                        while (patternIndex < pattern.Length &&
                            pattern[patternIndex] == '%')
                        {
                            patternIndex++;
                        }
                        if (patternIndex >= pattern.Length) p = '\0';
                        else p = pattern[patternIndex];
                    }
                    else if (p == '_')
                    {
                        isCharWildCardOn = true;
                        patternIndex++;
                    }
                    else if (p == '[')
                    {
                        if (pattern[++patternIndex] == '^')
                        {
                            isNotCharSetOn = true;
                            patternIndex++;
                        }
                        else isCharSetOn = true;

                        set.Clear();
                        if (pattern[patternIndex + 1] == '-' && pattern[patternIndex + 3] == ']')
                        {
                            char start = char.ToUpper(pattern[patternIndex]);
                            patternIndex += 2;
                            char end = char.ToUpper(pattern[patternIndex]);
                            if (start <= end)
                            {
                                for (char ci = start; ci <= end; ci++)
                                {
                                    set.Add(ci);
                                }
                            }
                            patternIndex++;
                        }

                        while (patternIndex < pattern.Length &&
                            pattern[patternIndex] != ']')
                        {
                            set.Add(pattern[patternIndex]);
                            patternIndex++;
                        }
                        patternIndex++;
                    }
                }

                if (isWildCardOn)
                {
                    if (char.ToUpper(c) == char.ToUpper(p))
                    {
                        isWildCardOn = false;
                        patternIndex++;
                    }
                }
                else if (isCharWildCardOn)
                {
                    isCharWildCardOn = false;
                }
                else if (isCharSetOn || isNotCharSetOn)
                {
                    bool charMatch = set.Contains(char.ToUpper(c));
                    if (isNotCharSetOn && charMatch || isCharSetOn && !charMatch)
                    {
                        if (lastWildCard >= 0) patternIndex = lastWildCard;
                        else
                        {
                            isMatch = false;
                            break;
                        }
                    }
                    isNotCharSetOn = isCharSetOn = false;
                }
                else
                {
                    if (char.ToUpper(c) == char.ToUpper(p))
                    {
                        patternIndex++;
                    }
                    else
                    {
                        if (lastWildCard >= 0) patternIndex = lastWildCard;
                        else
                        {
                            isMatch = false;
                            break;
                        }
                    }
                }
            }
            endOfPattern = patternIndex >= pattern.Length;

            if (isMatch && !endOfPattern)
            {
                bool isOnlyWildCards = true;
                for (int i = patternIndex; i < pattern.Length; i++)
                {
                    if (pattern[i] != '%')
                    {
                        isOnlyWildCards = false;
                        break;
                    }
                }
                if (isOnlyWildCards) endOfPattern = true;
            }
            return isMatch && endOfPattern;
        }

        public static IQueryable<T> Search<T>(this IQueryable<T> source, IEnumerable<SearchExpressionInfo<T>> criterias)
        {
            Expression? expr = null;
            var parameter = Expression.Parameter(typeof(T), "x");

            foreach (var criteria in criterias)
            {
                if (string.IsNullOrEmpty(criteria.SearchTerm))
                    continue;

                var propertySelector = ParameterReplacerVisitor.Replace(criteria.Selector, criteria.Selector.Parameters[0], parameter) as LambdaExpression;
                _ = propertySelector ?? throw new InvalidExpressionException();

                var likeExpression = Expression.Call(
                                        null,
                                        LikeMethodInfo,
                                        Functions,
                                        propertySelector.Body,
                                        Expression.Constant(criteria.SearchTerm));

                expr = expr == null ? (Expression)likeExpression : Expression.OrElse(expr, likeExpression);
            }

            return expr == null
                ? source
                : source.Where(Expression.Lambda<Func<T, bool>>(expr, parameter));
        }
    }
}
