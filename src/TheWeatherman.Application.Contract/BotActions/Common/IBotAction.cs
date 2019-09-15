using Telegram.Bot.Requests.Abstractions;
using Telegram.Bot.Types;
using TheWeatherman.Common.Result;

namespace TheWeatherman.Application.Contract.BotActions.Common
{
    public interface IBotAction : IRequest<Result>
    {
        int MessageId { get; set; }
        Chat Chat { get; set; }
        User From { get; set; }
        string Text { get; set; }
        bool CanHandle(string condition);
    }
}