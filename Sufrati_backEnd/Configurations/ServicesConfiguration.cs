using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Sufrati.Data.Configurations
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection ConfigureRepositories(this IServiceCollection services)
        {
            ///services.AddScoped<IGroupRepository, GroupRepository>();
            return services;
        }
        public static IServiceCollection ConfigureSupervisor(this IServiceCollection services)
        {
            //services.AddScoped< interface, class>();
            //services.AddScoped<IPCPSSupervisor, PCPSSupervisor>();

            return services;
        }
        public static IServiceCollection ConfigureMapper(this IServiceCollection services)
        {
            var config = new MapperConfiguration(cfg =>
            {
            });
            return services;
        }
        public static IServiceCollection AddConnection(this IServiceCollection services, IConfiguration configuration)
        {
            //var connection = configuration.GetConnectionString("PCPS_CS");
            //services.AddDbContext<PCPSContext>(options =>
            //    options.UseSqlServer(connection, b => b.MigrationsAssembly("PCPS.API")));
            return services;
        }
    }

}
