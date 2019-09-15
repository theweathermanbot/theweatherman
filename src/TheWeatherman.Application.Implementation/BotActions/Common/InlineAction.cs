using TheWeatherman.Application.Contract.BotActions.Common;
using TheWeatherman.Application.Contract.Common.Context;

namespace TheWeatherman.Application.Implementation.BotActions.Common
{
    public abstract class InlineAction : BotAction, IInlineAction
    {
        public string Query { get; set; }
        public string Offset { get; set; }
     
        public InlineAction(IBotContext botContext) : base(botContext)
        {
            Query = botContext.InlineQuery?.Query;
            Offset = botContext.InlineQuery?.Offset;
        }
    }
}