using WsmSystem.Erp.ReadModel.V1.Securities;

namespace WsmSystem.Erp.Service.Abstraction.V1.Securities
{
    public interface IClientInfoService
    {
        Task<List<ClientInfoDto>> GetAllClientInfoAsync(CancellationToken cancellationToken = default);
    }
}
