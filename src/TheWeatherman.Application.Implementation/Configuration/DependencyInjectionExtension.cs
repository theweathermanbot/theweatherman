using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Scrutor;
using TheWeatherman.Application.Contract.Client;
using TheWeatherman.Application.Implementation.Client;
using TheWeatherman.Application.Implementation.Service;
using TheWeatherman.Application.Implementation.Service.Background;

namespace TheWeatherman.Application.Implementation.Configuration
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection AddApplicationDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddBackgroundServices(configuration);
            services.AddServices(configuration);
            
            return services;
        }
        
        private static IServiceCollection AddBackgroundServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IBotClient, BotClient>();
            services.AddSingleton<IHostedService, TelegramBackgroundService>();

            return services;
        }
                
        private static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Scan(scan => scan
                .FromAssemblyOf<TelegramService>()
                .AddClasses(classes =>
                    classes.Where(c => c.Name.EndsWith("Service") && c.Name != "TelegramBackgroundService"))
                .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                .AsImplementedInterfaces()
                .WithScopedLifetime());
            
            return services;
        }
    }
}