using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WsmSystem.Erp.Contract;
using WsmSystem.Erp.Persistence.AppContext;

namespace WsmSystem.Erp.Persistence
{
    public static class PersistenceDependencyInjection
    {
        public static IServiceCollection AddDbService(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = string.Empty;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                connection = configuration.GetConnectionString("WsmSystemDbConnection") ??
                             "Server=127.0.0.1\\SqlExpress2019;Database=HanaErp;User id=sa;Password=Sa@123456;MultipleActiveResultSets=True;";
            services.AddEntityFrameworkSqlServer();
            services.AddScoped<IWsmSystemContext>(provider => provider.GetRequiredService<WsmSystemContext>())
                .AddDbContext<WsmSystemContext>((serviceProvider, options) =>
                    {
                        options.UseSqlServer(connection, sqlOptions => { sqlOptions.EnableRetryOnFailure(); });
                        options.UseInternalServiceProvider(serviceProvider);
                        options.EnableSensitiveDataLogging(); // in production its need to be turnoff
                    });

            return services;
        }
    }
}