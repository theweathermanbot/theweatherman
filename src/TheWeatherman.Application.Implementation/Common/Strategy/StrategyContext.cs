using System.Collections.Generic;
using TheWeatherman.Application.Contract.BotActions.Common;
using TheWeatherman.Application.Contract.Common.Strategy;

namespace TheWeatherman.Application.Implementation.Common.Strategy
{
    public class StrategyContext : IStrategyContext
    {
        protected IEnumerable<ICallbackAction> CallbackActions;
        protected IEnumerable<ICommandAction> CommandActions;
        protected IEnumerable<IInlineAction> InlineActions;

        public StrategyContext(IEnumerable<ICallbackAction> callbackActions, IEnumerable<ICommandAction> commandActions, IEnumerable<IInlineAction> inlineActions)
        {
            CallbackActions = callbackActions;
            CommandActions = commandActions;
            InlineActions = inlineActions;
        }

        public IEnumerable<ICallbackAction> GetCallbackStrategyContext()
        {
            return CallbackActions;
        }

        public IEnumerable<ICommandAction> GetCommandStrategyContext()
        {
            return CommandActions;
        }

        public IEnumerable<IInlineAction> GetInlineStrategyContext()
        {
            return InlineActions;
        }
    }
}