using Microsoft.EntityFrameworkCore.Query;

namespace WsmSystem.Erp.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        #region Commands Part
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);
        #endregion

        #region Query Part
        IQueryable<T> GetQueryable();
        public Task<List<T>>? GetListAsync(Expression<Func<T, bool>>? condition = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? includes = null, bool asNoTracking = true, CancellationToken cancellationToken = default);
        public Task<List<TResult>>? GetListAsync<TResult>(Expression<Func<T, TResult>> selectExpression, Expression<Func<T, bool>>? condition = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? includes = null, bool asNoTracking = true, CancellationToken cancellationToken = default);
        Task<List<T>> GetListAsync(ISpecification<T> specification, bool asNoTracking, CancellationToken cancellationToken = default);
        #endregion
    }
}
