using System.Linq.Expressions;
using WsmSystem.Erp.Domain.Interfaces.Repositories;

namespace WsmSystem.Erp.Persistence.Repositories.Repositories
{
    public class ClientInfoRepository : Repository<ClientInfo>, IClientInfoRepository
    {
        public ClientInfoRepository(IWsmSystemContext context) : base(context)
        {
        }
    }
}
