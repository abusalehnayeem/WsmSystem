using System.Linq.Expressions;
using WsmSystem.Erp.Domain.Specifications;

namespace WsmSystem.Erp.Persistence.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly DbContext _context;
        private readonly ISpecificationEvaluator _specificationEvaluator;
        protected BaseRepository(DbContext context, ISpecificationEvaluator specificationEvaluator)
        {
            _context = context;
            _specificationEvaluator = specificationEvaluator;
        }
        protected BaseRepository(DbContext context) : this(context, SpecificationEvaluator.Default)
        {
        }

        public void Add(T entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
            _context.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            if (entities is null) throw new ArgumentNullException(nameof(entities));
            _context.Set<T>().AddRange(entities);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate, ISpecification<T>? specification = null, CancellationToken cancellationToken = default) => await ApplySpecification(predicate, specification).CountAsync(cancellationToken);

        public void Delete(T entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
            _context.Set<T>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            if (entities is null) throw new ArgumentNullException(nameof(entities));
            _context.Set<T>().RemoveRange(entities);
        }

        public Task<T?> FirstOrDefault(Expression<Func<T, bool>> predicate, ISpecification<T>? specification = null, CancellationToken cancellationToken = default)
        {
            if (predicate is null) throw new ArgumentNullException(nameof(predicate));
            return InternalSingleReturn(predicate, specification, cancellationToken);
        }

        private async Task<T?> InternalSingleReturn(Expression<Func<T, bool>> predicate, ISpecification<T>? specification, CancellationToken cancellationToken)
        {
            return specification is null
                            ? await ApplySpecification(predicate, null).FirstOrDefaultAsync(predicate, cancellationToken)
                            : await ApplySpecification(predicate, specification).FirstOrDefaultAsync(cancellationToken);
        }

        public Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate, ISpecification<T>? specification = null, CancellationToken cancellationToken = default)
        {
            if (predicate is null) throw new ArgumentNullException(nameof(predicate));
            return specification is null
                ? InternalGetAllAsync(predicate, null, cancellationToken)
                : InternalGetAllAsync(predicate, specification, cancellationToken);
        }

        private async Task<List<T>> InternalGetAllAsync(Expression<Func<T, bool>> predicate, ISpecification<T>? specification, CancellationToken cancellationToken) => await ApplySpecification(predicate, specification).ToListAsync(cancellationToken);

        public void Update(T entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
            _context.Set<T>().Update(entity);
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            if (entities is null) throw new ArgumentNullException(nameof(entities));
            _context.Set<T>().UpdateRange(entities);
        }
        protected virtual IQueryable<T> ApplySpecification(Expression<Func<T, bool>> predicate, ISpecification<T>? specification = null)
        {
            if (predicate is null) throw new ArgumentNullException(nameof(predicate));
            return specification is null
                ? _specificationEvaluator.GetQuery(_context.Set<T>().Where(predicate).AsQueryable(), null)
                : _specificationEvaluator.GetQuery(_context.Set<T>().Where(predicate).AsQueryable(), specification);
        }
    }
}
