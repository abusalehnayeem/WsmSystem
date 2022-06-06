namespace WsmSystem.Erp.Domain.Interfaces
{
    public interface IEvaluator<T> where T : class
    {
        bool IsCriteriaEvaluator { get; }

        IQueryable<T> GetQuery(IQueryable<T> query, ISpecification<T> specification);
    }
}
