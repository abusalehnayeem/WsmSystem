namespace WsmSystem.Erp.Domain.Specifications
{
    public class WhereExpressionInfo<T>
    {
        private readonly Lazy<Func<T, bool>> filterFunc;

        public Expression<Func<T, bool>> Filter { get; }

        public WhereExpressionInfo(Expression<Func<T, bool>> filter)
        {
            _ = filter ?? throw new ArgumentNullException(nameof(filter));
            Filter = filter;
            filterFunc = new Lazy<Func<T, bool>>(Filter.Compile);
        }

        public Func<T, bool> FilterFunc => filterFunc.Value;
    }
}
