using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Net.Experience.Configuration.Providers;
using Net.Experience.Persistance.Sql;
using System;

namespace Net.Experience.Configuration
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            //INFRASTRUCTURE
            services.ConfigurePersistenceServices(configuration);

            return services;
        }


        public static void Configure(
            this IApplicationBuilder app,
            IConfiguration configuration)
        {
            using (var serviceScope = app.ApplicationServices
                             .GetRequiredService<IServiceScopeFactory>()
                             .CreateScope())
            {
                using var context = serviceScope.ServiceProvider.GetService<NetExperienceDbContext>();
                context.Database.Migrate();
            }
        }
    }
}
