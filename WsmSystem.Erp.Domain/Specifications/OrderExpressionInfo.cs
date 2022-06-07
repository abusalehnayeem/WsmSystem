using WsmSystem.Erp.Domain.Enums;

namespace WsmSystem.Erp.Domain.Specifications
{
    public class OrderExpressionInfo<T>
    {
        private readonly Lazy<Func<T, object?>> keySelectorFunc;

        public OrderExpressionInfo(Expression<Func<T, object?>> keySelector, OrderType orderType)
        {
            _ = keySelector ?? throw new ArgumentNullException(nameof(keySelector));

            KeySelector = keySelector;
            OrderType = orderType;

            keySelectorFunc = new Lazy<Func<T, object?>>(KeySelector.Compile);
        }

        public Expression<Func<T, object?>> KeySelector { get; }
        public OrderType OrderType { get; }
        public Func<T, object?> KeySelectorFunc => keySelectorFunc.Value;
    }
}
