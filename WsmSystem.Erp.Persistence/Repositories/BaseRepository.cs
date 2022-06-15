using Microsoft.EntityFrameworkCore.Query;
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

        #region command parts
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
        #endregion

        #region query parts

        public IQueryable<T> GetQueryable()
        {
            return _context.Set<T>().AsQueryable();
        }

        public async Task<List<T>> GetListAsync(ISpecification<T> specification, bool asNoTracking, CancellationToken cancellationToken = default)
        {
            var query = GetQueryable();

            if (specification != null)
            {
                query = _specificationEvaluator.GetQuery(query);
            }

            if (asNoTracking)
            {
                query = query.AsNoTracking();
            }

            return await query.ToListAsync(cancellationToken).ConfigureAwait(false);
        }

        public async Task<List<T>>? GetListAsync(Expression<Func<T, bool>>? condition = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? includes = null, bool asNoTracking = true, CancellationToken cancellationToken = default)
        {
            var query = GetQueryable();
            if (condition != null)
            {
                query = query.Where(condition);
            }

            if (includes != null)
            {
                query = includes(query);
            }

            if (asNoTracking)
            {
                query = query.AsNoTracking();
            }
            return await query.ToListAsync(cancellationToken).ConfigureAwait(false);
        }

        public Task<List<TResult>>? GetListAsync<TResult>(Expression<Func<T, TResult>> selectExpression, Expression<Func<T, bool>>? condition = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? includes = null, bool asNoTracking = true, CancellationToken cancellationToken = default)
        {
            var query = GetQueryable();
            if (condition != null)
            {
                query = query.Where(condition);
            }

            if (includes != null)
            {
                query = includes(query);
            }

            if (asNoTracking)
            {
                query = query.AsNoTracking();
            }

            if (selectExpression == null) throw new ArgumentNullException(nameof(selectExpression));
            return InternalGetListAsync(selectExpression, query, cancellationToken);
        }

        private async Task<List<TResult>> InternalGetListAsync<TResult>(Expression<Func<T, TResult>> selectExpression, IQueryable<T> query, CancellationToken cancellationToken)
        {
            return await query.Select(selectExpression).ToListAsync(cancellationToken).ConfigureAwait(false);
        }

        #endregion
    }
}
