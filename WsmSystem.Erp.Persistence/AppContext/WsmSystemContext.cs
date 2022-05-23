using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using WsmSystem.Erp.Contract;

namespace WsmSystem.Erp.Persistence.AppContext
{
    public partial class WsmSystemContext : DbContext
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
