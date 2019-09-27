using MihaZupan.TelegramBotClients;

namespace TheWeatherman.Application.Contract.Client
{
    public interface IBotClient
    {
        RateLimitedTelegramBotClient Client { get; }
    }
}