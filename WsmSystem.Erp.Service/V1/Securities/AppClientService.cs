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
            var contentList = await _unitOfWork.AppclientRepository.GetAllAsync();
            return contentList.Select(i => new AppClientDto()
            {
                Id = i.Id,
                AppClientName = i.AppClientName,
                ApplicationKey = i.ApplicationKey,
                ExpireDate = i.ExpireDate
            }).ToList();


        }
    }
}
