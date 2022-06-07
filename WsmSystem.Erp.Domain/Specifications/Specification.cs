namespace WsmSystem.Erp.Domain.Specifications
{
    public class Specification<T> : ISpecification<T>
    {
        protected IInMemorySpecificationEvaluator Evaluator { get; }
        protected ISpecificationValidator Validator { get; }

        protected Specification()
        : this(InMemorySpecificationEvaluator.Default, SpecificationValidator.Default)
        {
        }

        protected Specification(IInMemorySpecificationEvaluator inMemorySpecificationEvaluator) : this(inMemorySpecificationEvaluator, SpecificationValidator.Default)
        {
        }

        protected Specification(ISpecificationValidator specificationValidator)
            : this(InMemorySpecificationEvaluator.Default, specificationValidator)
        {
        }

        protected Specification(IInMemorySpecificationEvaluator inMemorySpecificationEvaluator, ISpecificationValidator specificationValidator)
        {
            Evaluator = inMemorySpecificationEvaluator;
            Validator = specificationValidator;
            Query = new SpecificationBuilder<T>(this);
        }

        public ISpecificationBuilder<T> Query { get; }
        public IDictionary<string, object> Items { get; set; } = new Dictionary<string, object>();
        public IEnumerable<WhereExpressionInfo<T>> WhereExpressions { get; } = new List<WhereExpressionInfo<T>>();
        public IEnumerable<OrderExpressionInfo<T>> OrderExpressions { get; } = new List<OrderExpressionInfo<T>>();
        public IEnumerable<IncludeExpressionInfo> IncludeExpressions { get; } = new List<IncludeExpressionInfo>();
        public IEnumerable<string> IncludeStrings { get; } = new List<string>();
        public IEnumerable<SearchExpressionInfo<T>> SearchCriterias { get; } = new List<SearchExpressionInfo<T>>();
        public int? Take { get; internal set; } = null;
        public int? Skip { get; internal set; } = null;
        public Func<IEnumerable<T>, IEnumerable<T>>? PostProcessingAction { get; internal set; } = null;
        public string? CacheKey { get; internal set; }
        public bool CacheEnabled { get; internal set; }
        public bool AsNoTracking { get; internal set; } = false;
        public bool AsSplitQuery { get; internal set; } = false;
        public bool AsNoTrackingWithIdentityResolution { get; internal set; } = false;
        public bool IgnoreQueryFilters { get; internal set; } = false;

        public IEnumerable<T> Evaluate(IEnumerable<T> entities)
        {
            return Evaluator.Evaluate(entities, this);
        }

        public bool IsSatisfiedBy(T entity)
        {
            return Validator.IsValid(entity, this);
        }
    }
}
