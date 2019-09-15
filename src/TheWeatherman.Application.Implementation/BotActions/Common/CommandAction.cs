using TheWeatherman.Application.Contract.BotActions.Common;
using TheWeatherman.Application.Contract.Common.Context;

namespace TheWeatherman.Application.Implementation.BotActions.Common
{
    public abstract class CommandAction : BotAction, ICommandAction
    {
        public CommandAction(IBotContext botContext) : base(botContext)
        {
        }
    }
}