using WsmSystem.Erp.Domain.NoNeedCodes.Interfaces;

namespace WsmSystem.Erp.Persistence.Repositories
{
    internal class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly IWsmSystemContext _context;
        private readonly ISpecificationEvaluator _specificationEvaluator;
        public BaseRepository(IWsmSystemContext context, ISpecificationEvaluator specificationEvaluator)
        {
            _context = context;
            _specificationEvaluator = specificationEvaluator;
        }

        public BaseRepository(IWsmSystemContext context) : this(context, SpecificationEvaluator.Default) { }
        public Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<T> FindByIdAsync(object id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<T> FindByIdAsync(object id, ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<T?> GetByIdAsync<TId>(TId id, CancellationToken cancellationToken = default) where TId : notnull
        {
            throw new NotImplementedException();
        }

        public Task<T?> GetBySpecAsync<Spec>(Spec specification, CancellationToken cancellationToken = default) where Spec : ISingleResultSpecification, ISpecification<T>
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> ListAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> ListAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
