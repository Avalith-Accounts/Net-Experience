using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Reflection;

namespace Net.Experience.Configuration.Providers
{
    public static class MediatorConfiguration
    {
        private const string APPLICATION_NAMESPACE = "Net.Experience.Application";
        public static IServiceCollection AddMediatorConfiguration(this IServiceCollection services)
        {
            var types = Assembly.Load(APPLICATION_NAMESPACE).GetTypes().Where(a => a.IsClass && a.Namespace != null && a.Name.EndsWith("Handler")).ToArray();

            services.AddMediatR(types);

            return services;
        }
    }
}
