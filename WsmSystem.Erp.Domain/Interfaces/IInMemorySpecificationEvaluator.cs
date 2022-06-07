namespace WsmSystem.Erp.Domain.Interfaces
{
    public interface IInMemorySpecificationEvaluator
    {
        IEnumerable<T> Evaluate<T>(IEnumerable<T> source, ISpecification<T> specification);
    }
}
