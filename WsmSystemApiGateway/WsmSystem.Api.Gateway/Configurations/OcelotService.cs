using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ocelot.DependencyInjection;

namespace WsmSystem.Api.Gateway.Configurations
{
    public static class OcelotService
    {
        public static IServiceCollection AddOcelotService(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddOcelot(configuration);
            return services;
        }
    }
}