using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MihaZupan.TelegramBotClients;
using Telegram.Bot.Types.Enums;
using TheWeatherman.Application.Contract.Client;

namespace TheWeatherman.Application.Implementation.Client
{
    public class BotClient : IBotClient
    {
        protected readonly ILogger<BotClient> Logger;
        public RateLimitedTelegramBotClient Client { get; }
        
        public bool Started { get; set; }
        
        public BotClient(IConfiguration configuration, ILogger<BotClient> logger)
        {
            Started = false;
            Logger = logger;
            
            try
            {
                Client = new RateLimitedTelegramBotClient(configuration["TELEGRAM_TOKEN"]);
                var me = Client.GetMeAsync().Result;
                
                Logger.LogInformation($"Telegram Bot Client is online for bot: @{me.Username}");
            }
            catch (Exception e)
            {
                Logger.LogError(e, "Error setting TelegramBotClient.");
                
                throw;
            }
        }

    }
}