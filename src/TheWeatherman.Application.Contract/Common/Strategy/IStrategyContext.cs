using System.Collections.Generic;
using TheWeatherman.Application.Contract.BotActions.Common;

namespace TheWeatherman.Application.Contract.Common.Strategy
{
    public interface IStrategyContext
    {
        IEnumerable<ICallbackAction> GetCallbackStrategyContext();
        IEnumerable<ICommandAction> GetCommandStrategyContext();
        IEnumerable<IInlineAction> GetInlineStrategyContext();
    }
}