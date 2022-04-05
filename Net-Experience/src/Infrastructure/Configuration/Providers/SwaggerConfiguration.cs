using Microsoft.Extensions.DependencyInjection;

namespace Net.Experience.Configuration.Providers
{
    public static class SwaggerConfiguration
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "Net Experience",
                    Version = "v1",
                    Description = "REST API Boilerplate"
                });
            });

            return services;
        }
    }
}
