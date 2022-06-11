namespace WsmSystem.Erp.Domain.Interfaces
{
    public interface ISpecificationEvaluator
    {
        IQueryable<T> GetQuery<T>(IQueryable<T> inputQuery, ISpecification<T>? specification = null) where T : BaseEntity;
    }
}
