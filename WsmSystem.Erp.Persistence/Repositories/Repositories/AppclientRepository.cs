using System.Linq.Expressions;
using WsmSystem.Erp.Domain.Interfaces.Repositories;

namespace WsmSystem.Erp.Persistence.Repositories.Repositories
{
    public class AppclientRepository : Repository<AppClient>, IAppclientRepository
    {
        public AppclientRepository(IWsmSystemContext context) : base(context)
        {
        }
    }
}
