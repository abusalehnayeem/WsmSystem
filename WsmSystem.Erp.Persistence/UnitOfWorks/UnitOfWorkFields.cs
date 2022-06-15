using WsmSystem.Erp.Domain.Interfaces.Repositories;

namespace WsmSystem.Erp.Persistence.UnitOfWorks
{
    public partial class UnitOfWork
    {
        #region securities

        private IAppclientRepository? _appclientRepository = null!;
        private IClientInfoRepository? _clientInfoRepository = null!;

        #endregion securities
    }
}
