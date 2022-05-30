using WsmSystem.Erp.Contract;

namespace WsmSystem.Erp.Api.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string IdUser => _httpContextAccessor?.HttpContext?.User?.Claims?.FirstOrDefault(c => c.Type == "preferred_username")?.Value ?? string.Empty;
    }
}