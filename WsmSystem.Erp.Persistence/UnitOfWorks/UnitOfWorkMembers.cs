using WsmSystem.Erp.Domain.Interfaces.Repositories;
using WsmSystem.Erp.Persistence.Repositories.Repositories;

namespace WsmSystem.Erp.Persistence.UnitOfWorks
{
    public partial class UnitOfWork
    {
        #region securities
        public IAppclientRepository AppclientRepository
        {
            get
            {
                return _appclientRepository ?? (_appclientRepository = new AppclientRepository(_context));
            }
        }
        #endregion

    }
}
