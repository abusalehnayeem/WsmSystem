namespace WsmSystem.Erp.Domain.Interfaces
{
    public interface ISpecificationValidator
    {
        bool IsValid<T>(T entity, ISpecification<T> specification);
    }
}
