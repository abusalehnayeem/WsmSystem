using WsmSystem.Erp.Domain.NoNeedCodes.Interfaces;

namespace WsmSystem.Erp.Domain.NoNeedCodes.Specifications
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
