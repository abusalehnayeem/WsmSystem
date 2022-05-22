using WsmSystem.Erp.Contract;

namespace WsmSystem.Erp.Api.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            IdUser = httpContextAccessor.HttpContext?.User?.Claims?.Where(c => c.Type == "preferred_username").FirstOrDefault()?.Value;
        }

        public string IdUser { get; }
    }
}