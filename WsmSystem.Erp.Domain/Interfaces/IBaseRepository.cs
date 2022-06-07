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

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void DeleteRange(IEnumerable<T> entities);
    }
}
