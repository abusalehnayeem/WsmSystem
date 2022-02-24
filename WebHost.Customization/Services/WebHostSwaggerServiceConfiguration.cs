using Microsoft.OpenApi.Models;

namespace WebHost.Customization.Services
{
    public static class WebHostSwaggerServiceConfiguration
    {
        private static string GetDocumentName(this IConfiguration configuration) => configuration["Swagger:Document:Name"];

        private static string GetDocumentTitle(this IConfiguration configuration) => configuration["Swagger:Document:Title"];

        private static string GetDocumentVersion(this IConfiguration configuration) => configuration["Swagger:Document:Version"];

        public static IServiceCollection SwaggerServiceConfiguration(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(configuration.GetDocumentName(),
                    new OpenApiInfo
                    { Title = configuration.GetDocumentTitle(), Version = configuration.GetDocumentVersion() });
            });
            return services;
        }
    }
}