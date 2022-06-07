using WsmSystem.Erp.Domain.NoNeedCodes.Interfaces;

namespace WsmSystem.Erp.Domain.NoNeedCodes.Specifications
{
    public class SpecificationValidator : ISpecificationValidator
    {
        private readonly List<IValidator> _validators = new List<IValidator>();
        public static SpecificationValidator Default { get; } = new SpecificationValidator();

        public SpecificationValidator() => _validators.AddRange(new IValidator[]
            {
                WhereValidator.Instance,
                SearchValidator.Instance
            });

        public SpecificationValidator(IEnumerable<IValidator> validators)
        {
            _validators.AddRange(validators);
        }

        public virtual bool IsValid<T>(T entity, ISpecification<T> specification)
        {
            foreach (var partialValidator in _validators)
            {
                if (!partialValidator.IsValid(entity, specification)) return false;
            }

            return true;
        }
    }
}
