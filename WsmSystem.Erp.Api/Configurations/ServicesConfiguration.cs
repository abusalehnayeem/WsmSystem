using WsmSystem.Erp.Api.Services;
using WsmSystem.Erp.Domain.Interfaces;

namespace WsmSystem.Erp.Api.Configurations
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection AddUserService(this IServiceCollection services)
        {
            services.AddScoped<ICurrentUserService, CurrentUserService>();
            return services;
        }
    }
}
