using Microsoft.AspNetCore.Mvc;
using WsmSystem.Erp.Service.Abstraction.V1.Securities;

namespace WsmSystem.Erp.Api.Controllers.V1.Securities
{
    [Route("api/appclient")]
    [ApiController]
    public class AppClientController : ControllerBase
    {
        private readonly IAppClientService _appClientService;

        public AppClientController(IAppClientService appClientService) => _appClientService = appClientService;

        [HttpGet]
        public async Task<IActionResult> GetAppClients(CancellationToken cancellationToken = default)
        {
            var appClientDtoList = await _appClientService.GetAllAppClientAsync(cancellationToken);
            return Ok(appClientDtoList);
        }
    }
}
