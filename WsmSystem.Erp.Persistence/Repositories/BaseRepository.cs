using System.Linq.Expressions;
using WsmSystem.Erp.Domain.Specifications;

namespace WsmSystem.Erp.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
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

        protected virtual IQueryable<T> ApplySpecification(Expression<Func<T, bool>>? predicate = null, ISpecification<T>? specification = null)
        {
            var query = _context.Set<T>().AsNoTracking().AsQueryable();
            if (predicate != null) query = query.Where(predicate);
            return _specificationEvaluator.GetQuery(query, specification);
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

        public async Task<T?> FirstOrDefault(Expression<Func<T, bool>>? predicate = null, ISpecification<T>? specification = null, CancellationToken cancellationToken = default)
        {
            return await ApplySpecification(predicate, specification).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<List<T>?> GetAllAsync(Expression<Func<T, bool>>? predicate = null, ISpecification<T>? specification = null, CancellationToken cancellationToken = default)
        {
            return await ApplySpecification(predicate, specification).ToListAsync(cancellationToken);
        }

        public async Task<int?> CountAsync(Expression<Func<T, bool>>? predicate = null, ISpecification<T>? specification = null, CancellationToken cancellationToken = default)
        {
            return await ApplySpecification(predicate, specification).CountAsync(cancellationToken);
        }


    }
}
