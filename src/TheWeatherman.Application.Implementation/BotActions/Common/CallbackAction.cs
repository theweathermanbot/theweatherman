using System.Collections.Generic;
using Newtonsoft.Json;
using TheWeatherman.Application.Contract.BotActions.Common;
using TheWeatherman.Application.Contract.Common.Context;

namespace TheWeatherman.Application.Implementation.BotActions.Common
{
    public abstract class CallbackAction : BotAction, ICallbackAction
    {
        public Dictionary<string, string> Data { get; set; }

        public CallbackAction(IBotContext botContext) : base(botContext)
        {
            Dictionary<string, string> callbackData;
            try
            {
                callbackData = JsonConvert.DeserializeObject<Dictionary<string, string>>(botContext.CallbackQuery.Data);
            }
            catch
            {
                callbackData = new Dictionary<string, string>();
            }

            Data = callbackData;
        }
    }
}