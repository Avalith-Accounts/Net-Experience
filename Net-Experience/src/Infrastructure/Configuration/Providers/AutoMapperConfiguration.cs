using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Net.Experience.Application.AutoMapper;

namespace Net.Experience.Configuration.Providers
{
    public static class AutoMapperConfiguration
    {
        public static IServiceCollection AddMapper(this IServiceCollection services)
        {
            MapperConfiguration mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMappingItem());
                mc.AddProfile(new AutoMappingUser());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}
