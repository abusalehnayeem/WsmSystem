using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WsmSystem.Erp.Domain.Entities.V1.Securities;
using WsmSystem.Erp.Domain.Interfaces;
using WsmSystem.Erp.ReadModel.V1.Securities;
using WsmSystem.Erp.Service.Abstraction.V1.Securities;

namespace WsmSystem.Erp.Service.V1.Securities
{
    public class ClientInfoService : IClientInfoService
    {

        private readonly IUnitOfWork _unitOfWork;

        public ClientInfoService(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;

        public async Task<List<ClientInfoDto>> GetAllClientInfoAsync(CancellationToken cancellationToken = default)
        {
            Expression<Func<ClientInfo, ClientInfoDto>> selectExpression = i => new ClientInfoDto
            {
                Id = i.Id,
                CompanyName = i.CompanyName,
                CompanyEmail = i.CompanyEmail,
                AppClientName = i.AppClient.AppClientName
            };
            var clientInfoList = await _unitOfWork?.ClientInfoRepository?.GetListAsync(selectExpression, null, null, true, cancellationToken);
            return clientInfoList;
        }
    }
}
