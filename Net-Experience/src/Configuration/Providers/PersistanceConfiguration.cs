using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Net.Experience.Persistance.Sql;

namespace Net.Experience.Configuration.Providers
{
    public static class PersistanceConfiguration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration, bool addHealthCheck = true)
        {

          services.AddDbContext<NetExperienceDbContext>(options =>
                                    options.UseSqlServer(configuration.GetConnectionString("SqlConnection")));

            return services;
        }
    }
}
