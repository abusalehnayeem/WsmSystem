namespace WsmSystem.Erp.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T?> GetByIdAsync<TId>(TId id, CancellationToken cancellationToken = default) where TId : notnull;

        Task<List<T>> ListAsync(CancellationToken cancellationToken = default);

        Task<List<T>> ListAsync(ISpecification<T> specification, CancellationToken cancellationToken = default);

        Task<T> FindByIdAsync(object id, CancellationToken cancellationToken = default);

        Task<T> FindByIdAsync(object id, ISpecification<T> specification, CancellationToken cancellationToken = default);

        Task<int> CountAsync(ISpecification<T> specification, CancellationToken cancellationToken = default);

        Task AddAsync(T entity, CancellationToken cancellationToken = default);
        Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);

        void Update(T entity);

        Task DeleteAsync(T entity, CancellationToken cancellationToken = default);

        void DeleteRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);
    }
}
