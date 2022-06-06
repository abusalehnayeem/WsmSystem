using WsmSystem.Erp.Domain.Interfaces;

namespace WsmSystem.Erp.Persistence.AppContext
{
    public partial class WsmSystemContext : DbContext
    {
        public WsmSystemContext() :
            base()
        {
        }

        public WsmSystemContext(DbContextOptions<WsmSystemContext> options, ICurrentUserService currentUserService) :
            base(options) => _currentUserService = currentUserService;
    }
}
