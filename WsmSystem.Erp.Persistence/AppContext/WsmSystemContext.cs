using Microsoft.EntityFrameworkCore;
using WsmSystem.Erp.Contract;

namespace WsmSystem.Erp.Persistence.AppContext
{
    public partial class WsmSystemContext : DbContext, IWsmSystemContext
    {
        public WsmSystemContext() :
            base()
        {

        }

        public WsmSystemContext(DbContextOptions<WsmSystemContext> options, ICurrentUserService currentUserService) :
            base(options)
        {
            _currentUserService = currentUserService;
        }
    }
}
