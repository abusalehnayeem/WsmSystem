namespace WsmSystem.Erp.Domain.NoNeedCodes.Interfaces
{
    public interface IEvaluator
    {
        bool IsCriteriaEvaluator { get; }

        IQueryable<T> GetQuery<T>(IQueryable<T> query, ISpecification<T> specification) where T : class;
    }
}
