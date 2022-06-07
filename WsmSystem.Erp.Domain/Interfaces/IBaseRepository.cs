namespace WsmSystem.Erp.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T?> GetByIdAsync<TId>(TId id, CancellationToken cancellationToken = default) where TId : notnull;

        Task<T?> GetBySpecAsync<Spec>(Spec specification, CancellationToken cancellationToken = default) where Spec : ISingleResultSpecification, ISpecification<T>;

        Task<List<T>> ListAsync(CancellationToken cancellationToken = default);

        Task<List<T>> ListAsync(ISpecification<T> specification, CancellationToken cancellationToken = default);

        Task<T> FindByIdAsync(object id, CancellationToken cancellationToken = default);

        Task<T> FindByIdAsync(object id, ISpecification<T> specification, CancellationToken cancellationToken = default);

        Task<int> CountAsync(ISpecification<T> specification, CancellationToken cancellationToken = default);

        Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);

        Task UpdateAsync(T entity, CancellationToken cancellationToken = default);

        Task DeleteAsync(T entity, CancellationToken cancellationToken = default);

        Task DeleteRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);
    }
}
