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
        protected string BOT_URL;
        
        public RateLimitedTelegramBotClient Client { get; }
        public bool Started { get; set; }
        
        public BotClient(IConfiguration configuration, ILogger<BotClient> logger)
        {
            Started = false;
            Logger = logger;
            BOT_URL = configuration["BOT_URL"];
            
            try
            {
                Client = new RateLimitedTelegramBotClient(configuration["TELEGRAM_TOKEN"]);
                
                var me = Client.GetMeAsync().Result;
                
                Logger.LogInformation($"Telegram Bot Client  for bot: @{me.Username}");
            }
            catch (Exception e)
            {
                Logger.LogError(e, "Error setting TelegramBotClient.");
                
                throw;
            }
        }
        
        public void Start()
        {
            if (Started == false)
            {
                var me = Client.GetMeAsync().Result;

                Client.SetWebhookAsync(BOT_URL).Wait();
                
                Logger.LogInformation($"Telegram Bot Client is receiving updates for bot: @{me.Username}");

                return;
            }
            
            Logger.LogWarning("Tried to start Telegram Bot Client update receiving when it's already running");
        }

    }
}