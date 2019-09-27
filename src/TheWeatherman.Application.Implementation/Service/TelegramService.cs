using System.Threading;
using Microsoft.Extensions.Logging;
using TheWeatherman.Application.Contract.Client;
using TheWeatherman.Application.Contract.Service;

namespace TheWeatherman.Application.Implementation.Service
{
    public class TelegramService : ITelegramService
    {
        protected readonly ILogger<TelegramService> Logger;
        protected readonly IBotClient Bot;

        public TelegramService(ILogger<TelegramService> logger, IBotClient bot)
        {
            Logger = logger;
            Bot = bot;
        }

        public void StartBot()
        {
            Bot.Start();

            Thread.Sleep(int.MaxValue);
        }
    }
}