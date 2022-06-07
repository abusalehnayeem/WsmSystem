namespace WsmSystem.Erp.Domain.Interfaces
{
    public interface ISpecification<T>
    {
        ISpecificationBuilder<T> Query { get; }
        IDictionary<string, object> Items { get; set; }
        IEnumerable<WhereExpressionInfo<T>> WhereExpressions { get; }
        IEnumerable<OrderExpressionInfo<T>> OrderExpressions { get; }
        IEnumerable<IncludeExpressionInfo> IncludeExpressions { get; }
        IEnumerable<string> IncludeStrings { get; }
        IEnumerable<SearchExpressionInfo<T>> SearchCriterias { get; }
        int? Take { get; }
        int? Skip { get; }
        Func<IEnumerable<T>, IEnumerable<T>>? PostProcessingAction { get; }
        bool CacheEnabled { get; }
        string? CacheKey { get; }
        bool AsNoTracking { get; }
        bool AsSplitQuery { get; }
        bool AsNoTrackingWithIdentityResolution { get; }
        bool IgnoreQueryFilters { get; }

        IEnumerable<T> Evaluate(IEnumerable<T> entities);

        bool IsSatisfiedBy(T entity);
    }
}
