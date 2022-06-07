namespace WsmSystem.Erp.Domain.NoNeedCodes.Interfaces
{
    public interface ISpecificationValidator
    {
        bool IsValid<T>(T entity, ISpecification<T> specification);
    }
}
