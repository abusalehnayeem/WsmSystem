namespace WsmSystem.Erp.Domain.NoNeedCodes.Interfaces
{
    public interface ISpecificationBuilder<T>
    {
        ISpecification<T> Specification { get; }
    }
}
