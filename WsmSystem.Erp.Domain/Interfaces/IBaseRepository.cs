﻿namespace WsmSystem.Erp.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
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
