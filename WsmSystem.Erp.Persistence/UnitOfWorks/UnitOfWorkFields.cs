using WsmSystem.Erp.Domain.Interfaces.Repositories;
using WsmSystem.Erp.Persistence.Repositories.Repositories;

namespace WsmSystem.Erp.Persistence.UnitOfWorks
{
    public partial class UnitOfWork
    {
        #region securities
        private IAppclientRepository? _appclientRepository;
        #endregion
    }
}
