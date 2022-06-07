namespace WsmSystem.Erp.Domain.Interfaces
{
    public interface IValidator
    {
        bool IsValid<T>(T entity, ISpecification<T> specification);
    }
}
