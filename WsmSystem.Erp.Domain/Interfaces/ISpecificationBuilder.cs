namespace WsmSystem.Erp.Domain.Interfaces
{
    public interface ISpecificationBuilder<T>
    {
        ISpecification<T> Specification { get; }
    }
}
