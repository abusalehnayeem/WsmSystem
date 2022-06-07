using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Reflection;
using WsmSystem.Erp.Domain.Enums;

namespace WsmSystem.Erp.Domain.Evaluators
{
    public class IncludeEvaluator : IEvaluator
    {
        private static readonly MethodInfo IncludeMethodInfo = typeof(EntityFrameworkQueryableExtensions)
            .GetTypeInfo().GetDeclaredMethods(nameof(EntityFrameworkQueryableExtensions.Include))
            .Single(mi => mi.GetGenericArguments().Length == 2
                && mi.GetParameters()[0].ParameterType.GetGenericTypeDefinition() == typeof(IQueryable<>)
                && mi.GetParameters()[1].ParameterType.GetGenericTypeDefinition() == typeof(Expression<>));

        private static readonly MethodInfo ThenIncludeAfterReferenceMethodInfo
            = typeof(EntityFrameworkQueryableExtensions)
                .GetTypeInfo().GetDeclaredMethods(nameof(EntityFrameworkQueryableExtensions.ThenInclude))
                .Single(mi => mi.GetGenericArguments().Length == 3
                    && mi.GetParameters()[0].ParameterType.GenericTypeArguments[1].IsGenericParameter
                    && mi.GetParameters()[0].ParameterType.GetGenericTypeDefinition() == typeof(IIncludableQueryable<,>)
                    && mi.GetParameters()[1].ParameterType.GetGenericTypeDefinition() == typeof(Expression<>));

        private static readonly MethodInfo ThenIncludeAfterEnumerableMethodInfo
            = typeof(EntityFrameworkQueryableExtensions)
                .GetTypeInfo().GetDeclaredMethods(nameof(EntityFrameworkQueryableExtensions.ThenInclude))
                .Where(mi => mi.GetGenericArguments().Length == 3)
                .Single(
                    mi =>
                    {
                        var typeInfo = mi.GetParameters()[0].ParameterType.GenericTypeArguments[1];

                        return typeInfo.IsGenericType
                            && typeInfo.GetGenericTypeDefinition() == typeof(IEnumerable<>)
                            && mi.GetParameters()[0].ParameterType.GetGenericTypeDefinition() == typeof(IIncludableQueryable<,>)
                            && mi.GetParameters()[1].ParameterType.GetGenericTypeDefinition() == typeof(Expression<>);
                    });

        private readonly bool cacheEnabled;

        private IncludeEvaluator(bool cacheEnabled)
        {
            this.cacheEnabled = cacheEnabled;
        }

        public static IncludeEvaluator Default { get; } = new IncludeEvaluator(false);
        public static IncludeEvaluator Cached { get; } = new IncludeEvaluator(true);

        public bool IsCriteriaEvaluator => false;

        public IQueryable<T> GetQuery<T>(IQueryable<T> query, ISpecification<T> specification) where T : class
        {
            foreach (var includeString in specification.IncludeStrings)
            {
                query = query.Include(includeString);
            }

            foreach (var includeInfo in specification.IncludeExpressions)
            {
                if (includeInfo.Type == IncludeTypeValue.Include)
                {
                    query = this.BuildInclude<T>(query, includeInfo);
                }
                else if (includeInfo.Type == IncludeTypeValue.ThenInclude)
                {
                    query = this.BuildThenInclude<T>(query, includeInfo);
                }
            }

            return query;
        }

        private IQueryable<T> BuildInclude<T>(IQueryable query, IncludeExpressionInfo includeInfo)
        {
            _ = includeInfo ?? throw new ArgumentNullException(nameof(includeInfo));
            var result = IncludeMethodInfo.MakeGenericMethod(includeInfo.EntityType, includeInfo.PropertyType).Invoke(null, new object[] { query, includeInfo.LambdaExpression });
            _ = result ?? throw new TargetException();
            return (IQueryable<T>)result;
        }

        private IQueryable<T> BuildThenInclude<T>(IQueryable query, IncludeExpressionInfo includeInfo)
        {
            _ = includeInfo ?? throw new ArgumentNullException(nameof(includeInfo));
            _ = includeInfo.PreviousPropertyType ?? throw new InvalidOperationException(nameof(includeInfo.PreviousPropertyType));
            var result = (IsGenericEnumerable(includeInfo.PreviousPropertyType, out var previousPropertyType)
                    ? ThenIncludeAfterEnumerableMethodInfo
                    : ThenIncludeAfterReferenceMethodInfo).MakeGenericMethod(includeInfo.EntityType, previousPropertyType, includeInfo.PropertyType)
                .Invoke(null, new object[] { query, includeInfo.LambdaExpression, });

            _ = result ?? throw new TargetException();

            return (IQueryable<T>)result;
        }

        private static bool IsGenericEnumerable(Type type, out Type propertyType)
        {
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IEnumerable<>))
            {
                propertyType = type.GenericTypeArguments[0];

                return true;
            }

            propertyType = type;

            return false;
        }
    }
}
