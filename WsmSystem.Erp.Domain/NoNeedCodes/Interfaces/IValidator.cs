namespace WsmSystem.Erp.Domain.NoNeedCodes.Interfaces
{
    public interface IValidator
    {
        bool IsValid<T>(T entity, ISpecification<T> specification);
    }
}
