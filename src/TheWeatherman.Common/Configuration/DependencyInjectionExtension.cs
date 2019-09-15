using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TheWeatherman.Common.Pipeline;

namespace TheWeatherman.Common.Configuration
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection AddPipelines(this IServiceCollection services, IConfiguration configuration)
        {
//            services.AddMediatR();
//            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPreProcessorBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPerformanceBehaviour<,>));
            
            return services;
        }
    }
}