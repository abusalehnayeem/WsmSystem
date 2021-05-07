using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Ocelot.Middleware;

namespace WsmSystem.Api.Gateway.HttpPipeline
{
    public static class DefaultPipeline
    {
        public static IApplicationBuilder UseDefaultPipeline(this IApplicationBuilder app, IConfiguration configuration,
            IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwaggerPipeline(configuration);
            }

            app.UseOcelot();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
            return app;
        }
    }
}