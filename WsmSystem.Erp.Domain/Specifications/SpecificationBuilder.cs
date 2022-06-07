namespace WsmSystem.Erp.Domain.Specifications
{
    public class SpecificationBuilder<T> : ISpecificationBuilder<T>
    {
        public ISpecification<T> Specification { get; }

        public SpecificationBuilder(ISpecification<T> specification)
        {
            Specification = specification;
        }
    }
}
