using System.Threading.Tasks;
using Telegram.Bot.Types;
using TheWeatherman.Application.Contract.Common.Client;

namespace TheWeatherman.Application.Contract.Common.Context
{
    public interface IBotContext
    {
        IBotClient BotClient { get; set; }
        Message Message { get; set; }
        CallbackQuery CallbackQuery { get; set; }
        InlineQuery InlineQuery { get; set; }
        User User { get; set; }
        Chat Chat { get; set; }
        
        void Populate(Message message);
        void Populate(CallbackQuery callbackQuery);
        void Populate(InlineQuery inlineQuery);

        /// <summary>
        /// Async method to get the username of the bot.
        /// </summary>
        /// <returns>Username of the bot.</returns>
        Task<string> GetBotName();
    }
}