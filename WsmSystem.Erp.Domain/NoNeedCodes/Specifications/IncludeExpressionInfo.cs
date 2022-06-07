using WsmSystem.Erp.Domain.Enums;

namespace WsmSystem.Erp.Domain.NoNeedCodes.Specifications
{
    public class IncludeExpressionInfo
    {
        public LambdaExpression LambdaExpression { get; }
        public Type EntityType { get; }
        public Type PropertyType { get; }
        public Type? PreviousPropertyType { get; }
        public IncludeTypeValue Type { get; }

        private IncludeExpressionInfo(LambdaExpression expression,
                                      Type entityType,
                                      Type propertyType,
                                      Type? previousPropertyType,
                                      IncludeTypeValue includeType)

        {
            _ = expression ?? throw new ArgumentNullException(nameof(expression));
            _ = entityType ?? throw new ArgumentNullException(nameof(entityType));
            _ = propertyType ?? throw new ArgumentNullException(nameof(propertyType));

            if (includeType == IncludeTypeValue.ThenInclude)
            {
                _ = previousPropertyType ?? throw new ArgumentNullException(nameof(previousPropertyType));
            }

            LambdaExpression = expression;
            EntityType = entityType;
            PropertyType = propertyType;
            PreviousPropertyType = previousPropertyType;
            Type = includeType;
        }

        public IncludeExpressionInfo(LambdaExpression expression,
                                     Type entityType,
                                     Type propertyType)
            : this(expression, entityType, propertyType, null, IncludeTypeValue.Include)
        {
        }

        public IncludeExpressionInfo(LambdaExpression expression,
                                     Type entityType,
                                     Type propertyType,
                                     Type previousPropertyType)
            : this(expression, entityType, propertyType, previousPropertyType, IncludeTypeValue.ThenInclude)
        {
        }
    }
}
