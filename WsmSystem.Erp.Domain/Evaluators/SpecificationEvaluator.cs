namespace WsmSystem.Erp.Domain.Evaluators
{
    public class SpecificationEvaluator : ISpecificationEvaluator
    {
        public static SpecificationEvaluator Default { get; } = new SpecificationEvaluator();
        private readonly List<IEvaluator> _evaluators = new List<IEvaluator>();

        public SpecificationEvaluator()
        {
            _evaluators.AddRange(new IEvaluator[]
            {
                WhereEvaluator.Instance,
                SearchEvaluator.Instance,
                IncludeEvaluator.Default,
                OrderEvaluator.Instance,
                PaginationEvaluator.Instance,
                AsNoTrackingEvaluator.Instance,
                IgnoreQueryFiltersEvaluator.Instance,
                AsSplitQueryEvaluator.Instance,
                AsNoTrackingWithIdentityResolutionEvaluator.Instance
            });
        }

        public SpecificationEvaluator(IEnumerable<IEvaluator> evaluators)
        {
            _evaluators.AddRange(evaluators);
        }

        public virtual IQueryable<T> GetQuery<T>(IQueryable<T> inputQuery, ISpecification<T> specification, bool evaluateCriteriaOnly = false) where T : class
        {
            if (specification is null)
            {
                throw new ArgumentNullException(nameof(specification), "Specification is required");
            }

            var evaluators = evaluateCriteriaOnly ? _evaluators.Where(x => x.IsCriteriaEvaluator) : _evaluators;

            foreach (var evaluator in evaluators)
            {
                inputQuery = evaluator.GetQuery(inputQuery, specification);
            }

            return inputQuery;
        }
    }
}
