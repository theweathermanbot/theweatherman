using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TheWeatherman.Application.Implementation.Configuration;

namespace TheWeatherman.Api.WebApi.Configuration
{
    public static class DependencyInversionExtension
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplicationDependencies(configuration);
            
            return services;
        }
    }
}