namespace WsmSystem.Erp.Domain.Specifications
{
    public class InMemorySpecificationEvaluator : IInMemorySpecificationEvaluator
    {
        private readonly List<IInMemoryEvaluator> _evaluators = new List<IInMemoryEvaluator>();
        public static InMemorySpecificationEvaluator Default { get; } = new InMemorySpecificationEvaluator();

        public InMemorySpecificationEvaluator() => _evaluators.AddRange(new IInMemoryEvaluator[]
            {
                WhereEvaluator.Instance,
                SearchEvaluator.Instance,
                OrderEvaluator.Instance,
                PaginationEvaluator.Instance
            });

        public InMemorySpecificationEvaluator(IEnumerable<IInMemoryEvaluator> evaluators) => _evaluators.AddRange(evaluators);

        public virtual IEnumerable<T> Evaluate<T>(IEnumerable<T> source, ISpecification<T> specification)
        {
            foreach (var evaluator in _evaluators)
            {
                source = evaluator.Evaluate(source, specification);
            }

            return specification.PostProcessingAction == null
                ? source
                : specification.PostProcessingAction(source);
        }
    }
}
