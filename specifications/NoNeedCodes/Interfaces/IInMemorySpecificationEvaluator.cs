namespace WsmSystem.Erp.Domain.NoNeedCodes.Interfaces
{
    public interface IInMemorySpecificationEvaluator
    {
        IEnumerable<T> Evaluate<T>(IEnumerable<T> source, ISpecification<T> specification);
    }
}
