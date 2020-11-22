using Immobiles.Data.Context;
using Immobiles.Data.Repository;
using Immobiles.Domain.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Immobiles.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services) 
        {
            services.AddScoped<MyDbContext>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
