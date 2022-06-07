namespace WsmSystem.Erp.Domain.NoNeedCodes.Interfaces
{
    public interface IInMemoryEvaluator
    {
        IEnumerable<T> Evaluate<T>(IEnumerable<T> query, ISpecification<T> specification);
    }
}
