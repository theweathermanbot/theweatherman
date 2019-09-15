using MihaZupan.TelegramBotClients;

namespace TheWeatherman.Application.Contract.Common.Client
{
    public interface IBotClient
    {
        BlockingTelegramBotClient Client { get; }
        void Start();
    }
}