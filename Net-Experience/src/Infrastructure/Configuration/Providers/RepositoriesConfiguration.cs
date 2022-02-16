﻿using Microsoft.Extensions.DependencyInjection;
using Net.Experience.Domain.Interfaces.Command;
using Net.Experience.Domain.Interfaces.Query;
using Net.Experience.Persistance.Sql.Command;
using Net.Experience.Persistance.Sql.Query;

namespace Net.Experience.Configuration.Providers
{
    public static class RepositoryConfiguration 
    {
        public static IServiceCollection AddPersonConfiguration(this IServiceCollection services)
        {
            // SERVICE
            services.AddScoped<IItemRepository, ItermRepository>();

            // Query
            services.AddScoped<IItemQuery, ItemQuery>();

            return services;
        }
    }  
}