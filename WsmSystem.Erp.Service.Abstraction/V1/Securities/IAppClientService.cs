using WsmSystem.Erp.ReadModel.V1.Securities;

namespace WsmSystem.Erp.Service.Abstraction.V1.Securities
{
    public interface IAppClientService
    {
        Task<List<AppClientDto>> GetAllAppClientAsync(CancellationToken cancellationToken = default);
    }
}
