using WsmSystem.Erp.Domain.Interfaces.Repositories;

namespace WsmSystem.Erp.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        #region Securities
        IAppclientRepository AppclientRepository { get; }
        IClientInfoRepository ClientInfoRepository { get; }
        #endregion

        #region core method
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        #endregion
    }
}
