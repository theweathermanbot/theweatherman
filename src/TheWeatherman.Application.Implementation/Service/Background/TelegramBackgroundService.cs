﻿using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using TheWeatherman.Application.Contract.Service;

namespace TheWeatherman.Application.Implementation.Service.Background
{
    public class TelegramBackgroundService : BackgroundService
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public TelegramBackgroundService(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var botService = scope.ServiceProvider.GetRequiredService<ITelegramService>();
                
                botService.StartBot();
            }

            return Task.CompletedTask;
        }
    }
}