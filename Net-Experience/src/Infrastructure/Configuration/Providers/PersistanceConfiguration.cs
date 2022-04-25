using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Net.Experience.Domain.Entities;
using Net.Experience.Persistance.Sql;

namespace Net.Experience.Configuration.Providers
{
    public static class PersistanceConfiguration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration, bool addHealthCheck = true)
        {

            services.AddDbContext<NetExperienceDbContext>(options =>
                                      options.UseSqlServer(configuration.GetConnectionString("SqlConnection")));

            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Password.RequiredLength = 6;
                options.Password.RequireUppercase = true;
            })
                .AddEntityFrameworkStores<NetExperienceDbContext>()
                .AddDefaultTokenProviders();

            return services;
        }
    }
}
