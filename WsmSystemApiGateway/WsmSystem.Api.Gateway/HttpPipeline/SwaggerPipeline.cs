using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using WsmSystem.Api.Gateway.Configurations;

namespace WsmSystem.Api.Gateway.HttpPipeline
{
    public static class SwaggerPipeline
    {
        public static IApplicationBuilder UseSwaggerPipeline(this IApplicationBuilder app, IConfiguration configuration)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint(configuration.GetEndpointUrl(), configuration.GetEndpointName());
                c.RoutePrefix = string.Empty;
            });
            return app;
        }
    }
}