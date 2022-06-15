using WsmSystem.Erp.Domain.Interfaces.Repositories;
using WsmSystem.Erp.Persistence.Repositories.Repositories;

namespace WsmSystem.Erp.Persistence.UnitOfWorks
{
    public partial class UnitOfWork
    {
        #region securities

        public IAppclientRepository AppclientRepository => _appclientRepository ??= new AppclientRepository(_context);
        public IClientInfoRepository ClientInfoRepository => _clientInfoRepository ??= new ClientInfoRepository(_context);

        #endregion securities
    }
}
