using Microsoft.Extensions.DependencyInjection;
using WsmSystem.Erp.Service.Abstraction.V1.Securities;
using WsmSystem.Erp.Service.V1.Securities;

namespace WsmSystem.Erp.Service
{
    public static class ServiceDependencyInjection
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            #region securities

            services.AddScoped<IAppClientService, AppClientService>();
            services.AddScoped<IClientInfoService, ClientInfoService>();

            #endregion securities

            return services;
        }
    }
}
