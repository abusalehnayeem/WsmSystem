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
        Task<T?> FirstOrDefault(Expression<Func<T, bool>> predicate, ISpecification<T>? specification = null, CancellationToken cancellationToken = default);

        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate, ISpecification<T>? specification = null, CancellationToken cancellationToken = default);

        Task<int> CountAsync(Expression<Func<T, bool>> predicate, ISpecification<T>? specification = null, CancellationToken cancellationToken = default);
        #endregion
    }
}
