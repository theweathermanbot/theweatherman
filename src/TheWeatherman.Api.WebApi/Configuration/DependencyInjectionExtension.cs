using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TheWeatherman.Api.WebApi.Configuration
{
    public static class DependencyInversionExtension
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            
            return services;
        }
    }
}