using System.Linq.Expressions;
using WsmSystem.Erp.Domain.Entities.V1.Securities;
using WsmSystem.Erp.Domain.Interfaces;
using WsmSystem.Erp.ReadModel.V1.Securities;
using WsmSystem.Erp.Service.Abstraction.V1.Securities;

namespace WsmSystem.Erp.Service.V1.Securities
{
    public class AppClientService : IAppClientService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AppClientService(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;

        public async Task<List<AppClientDto>> GetAllAppClientAsync(CancellationToken cancellationToken = default)
        {
            Expression<Func<AppClient, AppClientDto>> selectExpression = i => new AppClientDto
            {
                Id = i.Id,
                AppClientName = i.AppClientName,
                ApplicationKey = i.ApplicationKey
            };
            var appClientList = await _unitOfWork?.AppclientRepository?.GetListAsync(selectExpression, null, null, true, cancellationToken);
            return appClientList;
        }
    }
}
