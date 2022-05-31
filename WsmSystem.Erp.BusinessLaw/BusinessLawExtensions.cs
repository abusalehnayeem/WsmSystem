namespace WsmSystem.Erp.BusinessLaw
{
    public static class BusinessLawExtensions
    {
        /// <summary>
        /// Throws an <see cref="ArgumentNullException" /> if <paramref name="input" /> is null.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="businessLaw"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <param name="message">Optional. Custom error message</param>
        /// <returns><paramref name="input" /> if the value is not null.</returns>
        public static T Null<T>(this IBusinessLaw businessLaw, T input, string? parameterName = null, string? message = null)
        {
            if (input is not null)
            {
                return input;
            }
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentNullException(parameterName);
            }
            throw new ArgumentNullException(parameterName, message);
        }
        /// <summary>
        /// Throws an <see cref="ArgumentNullException" /> if <paramref name="input" /> is null.
        /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is an empty string.
        /// </summary>
        /// <param name="businessLaw"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <param name="message">Optional. Custom error message</param>
        /// <returns><paramref name="input" /> if the value is not an empty string or null.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static string NullOrEmpty(this IBusinessLaw businessLaw, string? input, string? parameterName = null, string? message = null)
        {
            BusinessLaw.Instance.Null(input, parameterName, message);
            if (input == string.Empty)
            {
                throw new ArgumentNullException(message ?? $"Required input {parameterName} was empty.", parameterName);
            }
            return input!;
        }
        /// <summary>
        /// Throws an <see cref="ArgumentNullException" /> if <paramref name="input" /> is null.
        /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is an empty enumerable.
        /// </summary>
        /// <param name="businessLaw"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <param name="message">Optional. Custom error message</param>
        /// <returns><paramref name="input" /> if the value is not an empty enumerable or null.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static IEnumerable<T> NullOrEmpty<T>(this IBusinessLaw businessLaw, IEnumerable<T>? input, string? parameterName = null, string? message = null)
        {
            BusinessLaw.Instance.Null(input, parameterName, message);
            if (input == null || !input.Any())
            {
                throw new ArgumentException(message ?? $"Required input {parameterName} was empty.", parameterName);
            }
            return input!;
        }
        /// <summary>
        /// Throws an <see cref="ArgumentNullException" /> if <paramref name="input" /> is null.
        /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is an empty or white space string.
        /// </summary>
        /// <param name="businessLaw"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <param name="message">Optional. Custom error message</param>
        /// <returns><paramref name="input" /> if the value is not an empty or whitespace string.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static string NullOrWhiteSpace(this IBusinessLaw businessLaw, string? input, string? parameterName = null, string? message = null)
        {
            BusinessLaw.Instance.NullOrEmpty(input, parameterName, message);
            return string.IsNullOrWhiteSpace(input)
                ? throw new ArgumentException(message ?? $"Required input {parameterName} was empty.", parameterName)
                : input;
        }
        /// <summary>
        /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is default for that type.
        /// </summary>
        /// <param name="businessLaw"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <param name="message">Optional. Custom error message</param>
        /// <returns><paramref name="input" /> if the value is not default for that type.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static T Default<T>(this IBusinessLaw businessLaw, T input, string? parameterName = null, string? message = null)
        {
            if (EqualityComparer<T>.Default.Equals(input, default(T)!) || input is null)
            {
                throw new ArgumentException(message ?? $"Parameter [{parameterName}] is default value for type {typeof(T).Name}", parameterName);
            }
            return input;
        }
        /// <summary>
        /// Throws an <see cref="ArgumentException" /> if  <paramref name="input"/> doesn't satisfy the <paramref name="predicate"/> function.
        /// </summary>
        /// <param name="guardClause"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <param name="predicate"></param>
        /// <param name="message">Optional. Custom error message</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static T InvalidInput<T>(this IBusinessLaw businessLaw, T input, string parameterName, Func<T, bool> predicate, string? message = null)
        {
            if (!predicate(input))
            {
                throw new ArgumentException(message ?? $"Input {parameterName} did not satisfy the options", parameterName);
            }

            return input;
        }
        /// <summary>
        /// Throws an <see cref="ArgumentException" /> if  <paramref name="input"/> doesn't match the <paramref name="regexPattern"/>.
        /// </summary>
        /// <param name="businessLaw"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <param name="regexPattern"></param>
        /// <param name="message">Optional. Custom error message</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string InvalidFormat(this IBusinessLaw businessLaw, string input, string parameterName, string regexPattern, string? message = null)
        {
            var m = Regex.Match(input, regexPattern);
            if (!m.Success || input != m.Value)
            {
                throw new ArgumentException(message ?? $"Input {parameterName} was not in required format", parameterName);
            }

            return input;
        }
        /// <summary>
        /// Throws an <see cref="ArgumentNullException"/> if <paramref name="input"/> is null
        /// Throws an <see cref="ArgumentException" /> if <paramref name="input"/> doesn't satisfy the <paramref name="predicate"/> function.
        /// </summary>
        /// <param name="businessLaw"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <param name="predicate"></param>
        /// <param name="message">Optional. Custom error message</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public static T NullOrInvalidInput<T>(this IBusinessLaw businessLaw, T input, string parameterName, Func<T, bool> predicate, string? message = null)
        {
            BusinessLaw.Instance.Null(input, parameterName, message);
            return BusinessLaw.Instance.InvalidInput(input, parameterName, predicate, message);
        }
        /// <summary>
        /// Throws an <see cref="ArgumentException" /> if <paramref name="func"/> evaluates to false for given <paramref name="input"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="func"></param>
        /// <param name="businessLaw"></param>
        /// <param name="input"></param>
        /// <param name="message"></param>
        /// <returns><paramref name="input"/> if the <paramref name="func"/> evaluates to true </returns>
        /// <exception cref="ArgumentException"></exception>
        public static T AgainstExpression<T>(this IBusinessLaw businessLaw, Func<T, bool> func, T input, string message) where T : struct
        {
            if (!func(input))
            {
                throw new ArgumentException(message);
            }

            return input;
        }
        /// <summary>
        /// Throws an <see cref="ArgumentException" /> if <paramref name="input"/> is negative.
        /// </summary>
        /// <param name="businessLaw"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <param name="message">Optional. Custom error message</param>
        /// <returns><paramref name="input" /> if the value is not negative.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static int Negative(this IBusinessLaw businessLaw, int input, string? parameterName = null, string? message = null)
        {
            return Negative<int>(businessLaw, input, parameterName, message);
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException" /> if <paramref name="input"/> is negative.
        /// </summary>
        /// <param name="businessLaw"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <param name="message">Optional. Custom error message</param>
        /// <returns><paramref name="input" /> if the value is not negative.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static long Negative(this IBusinessLaw businessLaw, long input,string? parameterName = null,string? message = null)
        {
            return Negative<long>(businessLaw, input, parameterName, message);
        }
        /// <summary>
        /// Throws an <see cref="ArgumentException" /> if <paramref name="input"/> is negative.
        /// </summary>
        /// <param name="businessLaw"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <param name="message">Optional. Custom error message</param>
        /// <returns><paramref name="input" /> if the value is not negative.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static decimal Negative(this IBusinessLaw businessLaw, decimal input, string? parameterName = null, string? message = null)
        {
            return Negative<decimal>(businessLaw, input, parameterName, message);
        }
        /// <summary>
        /// Throws an <see cref="ArgumentException" /> if <paramref name="input"/> is negative.
        /// </summary>
        /// <param name="businessLaw"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <param name="message">Optional. Custom error message</param>
        /// <returns><paramref name="input" /> if the value is not negative.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static float Negative(this IBusinessLaw businessLaw, float input, string? parameterName = null, string? message = null)
        {
            return Negative<float>(businessLaw, input, parameterName, message);
        }
        /// <summary>
        /// Throws an <see cref="ArgumentException" /> if <paramref name="input"/> is negative.
        /// </summary>
        /// <param name="businessLaw"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <param name="message">Optional. Custom error message</param>
        /// <returns><paramref name="input" /> if the value is not negative.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static double Negative(this IBusinessLaw businessLaw, double input, string? parameterName = null, string? message = null)
        {
            return Negative<double>(businessLaw, input, parameterName, message);
        }
        /// <summary>
        /// Throws an <see cref="ArgumentException" /> if <paramref name="input"/> is negative.
        /// </summary>
        /// <param name="businessLaw"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <param name="message">Optional. Custom error message</param>
        /// <returns><paramref name="input" /> if the value is not negative.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static TimeSpan Negative(this IBusinessLaw businessLaw, TimeSpan input, string? parameterName = null, string? message = null)
        {
            return Negative<TimeSpan>(businessLaw, input, parameterName, message);
        }
        /// <summary>
        /// Throws an <see cref="ArgumentException" /> if <paramref name="input"/> is negative.
        /// </summary>
        /// <param name="businessLaw"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <param name="message">Optional. Custom error message</param>
        /// <returns><paramref name="input" /> if the value is not negative.</returns>
        /// <exception cref="ArgumentException"></exception>
        private static T Negative<T>(this IBusinessLaw businessLaw, T input, string? parameterName = null, string? message = null) where T : struct, IComparable
        {
            if (input.CompareTo(default(T)) < 0)
            {
                throw new ArgumentException(message ?? $"Required input {parameterName} cannot be negative.", parameterName);
            }
            return input;
        }
        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if <paramref name="input"/> is negative or zero.
        /// </summary>
        /// <param name="businessLaw"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <param name="message">Optional. Custom error message</param>
        /// <returns><paramref name="input" /> if the value is not negative or zero.</returns>
        public static int NegativeOrZero(this IBusinessLaw businessLaw, int input, string? parameterName = null, string? message = null)
        {
            return NegativeOrZero<int>(businessLaw, input, parameterName, message);
        }
        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if <paramref name="input"/> is negative or zero.
        /// </summary>
        /// <param name="businessLaw"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <param name="message">Optional. Custom error message</param>
        /// <returns><paramref name="input" /> if the value is not negative or zero.</returns>
        public static long NegativeOrZero(this IBusinessLaw businessLaw, long input, string? parameterName = null, string? message = null)
        {
            return NegativeOrZero<long>(businessLaw, input, parameterName, message);
        }
        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if <paramref name="input"/> is negative or zero.
        /// </summary>
        /// <param name="businessLaw"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <param name="message">Optional. Custom error message</param>
        /// <returns><paramref name="input" /> if the value is not negative or zero.</returns>
        public static decimal NegativeOrZero(this IBusinessLaw businessLaw, decimal input, string? parameterName = null, string? message = null)
        {
            return NegativeOrZero<decimal>(businessLaw, input, parameterName, message);
        }
        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if <paramref name="input"/> is negative or zero.
        /// </summary>
        /// <param name="businessLaw"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <param name="message">Optional. Custom error message</param>
        /// <returns><paramref name="input" /> if the value is not negative or zero.</returns>
        public static float NegativeOrZero(this IBusinessLaw businessLaw, float input, string? parameterName = null, string? message = null)
        {
            return NegativeOrZero<float>(businessLaw, input, parameterName, message);
        }
        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if <paramref name="input"/> is negative or zero.
        /// </summary>
        /// <param name="businessLaw"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <param name="message">Optional. Custom error message</param>
        /// <returns><paramref name="input" /> if the value is not negative or zero.</returns>
        public static double NegativeOrZero(this IBusinessLaw businessLaw, double input, string? parameterName = null, string? message = null)
        {
            return NegativeOrZero<double>(businessLaw, input, parameterName, message);
        }
        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if <paramref name="input"/> is negative or zero.
        /// </summary>
        /// <param name="businessLaw"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <param name="message">Optional. Custom error message</param>
        /// <returns><paramref name="input" /> if the value is not negative or zero.</returns>
        public static TimeSpan NegativeOrZero(this IBusinessLaw businessLaw, TimeSpan input, string? parameterName = null, string? message = null)
        {
            return NegativeOrZero<TimeSpan>(businessLaw, input, parameterName, message);
        }
        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if <paramref name="input"/> is negative or zero.
        /// </summary>
        /// <param name="businessLaw"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <param name="message">Optional. Custom error message</param>
        /// <returns><paramref name="input" /> if the value is not negative or zero.</returns>
        private static T NegativeOrZero<T>(this IBusinessLaw businessLaw, T input, string? parameterName = null, string? message = null) where T : struct, IComparable
        {
            if (input.CompareTo(default(T)) <= 0)
            {
                throw new ArgumentException(message ?? $"Required input {parameterName} cannot be zero or negative.", parameterName);
            }
            return input;
        }
        /// <summary>
        /// Throws an <see cref="NotFoundException" /> if <paramref name="input" /> with <paramref name="key" /> is not found.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="businessLaw"></param>
        /// <param name="key"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <returns><paramref name="input" /> if the value is not null.</returns>
        /// <exception cref="NotFoundException"></exception>
        public static T NotFound<T>(this IBusinessLaw businessLaw, string key, T input, string? parameterName = null)
        {
            businessLaw.NullOrEmpty(key, nameof(key));

            if (input is null)
            {
                throw new NotFoundException(key, parameterName!);
            }

            return input;
        }
        /// <summary>
        /// Throws an <see cref="NotFoundException" /> if <paramref name="input" /> with <paramref name="key" /> is not found.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="guardClause"></param>
        /// <param name="key"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <returns><paramref name="input" /> if the value is not null.</returns>
        /// <exception cref="NotFoundException"></exception>
        public static T NotFound<TKey, T>(this IBusinessLaw businessLaw, TKey key, T input, string? parameterName = null) where TKey : struct
        {
            businessLaw.Null(key, nameof(key));

            if (input is null)
            {
                // TODO: Can we safely consider that ToString() won't return null for struct?
                throw new NotFoundException(key.ToString()!, parameterName!);
            }

            return input;
        }
    }
}
