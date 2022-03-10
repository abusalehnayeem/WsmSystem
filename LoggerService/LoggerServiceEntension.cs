using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;

namespace LoggerService
{
    public static class LoggerServiceEntension
    {
        public static IHostBuilder LoggerServiceBuilder(this IHostBuilder hostBuilder)
        {
            var logger = new LoggerConfiguration()
                            .MinimumLevel.Information()
                            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                            .Enrich.FromLogContext()
                            .WriteTo.Console()
                            .CreateLogger();
            return hostBuilder.ConfigureServices(services =>
            {
                services.AddSingleton<ILoggerService, LoggerService>();
            }).UseSerilog(logger);
        }
    }
}