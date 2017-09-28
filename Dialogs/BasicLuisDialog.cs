using System;
using System.Configuration;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

namespace Microsoft.Bot.Sample.LuisBot
{
    // For more information about this template visit http://aka.ms/azurebots-csharp-luis
    // // Go to https://luis.ai and create a new intent, then train/publish your luis app.
    [Serializable]
    public class BasicLuisDialog : LuisDialog<object>
    {
        public BasicLuisDialog() : base(new LuisService(new LuisModelAttribute(ConfigurationManager.AppSettings["LuisAppId"], ConfigurationManager.AppSettings["LuisAPIKey"])))
        {
        }

        [LuisIntent("None")]
        public async Task NoneIntent(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"You have reached the none intent. You said: {result.Query}"); //
            context.Wait(MessageReceived);
        }

        [LuisIntent("HomeAutomation.TurnOn")]
        public async Task TurnOnIntent(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"You have reached the TurnOn intent. You said: {result.Query}"); //
            context.Wait(MessageReceived);
        }
        
        [LuisIntent("HomeAutomation.TurnOff")]
        public async Task TurnOffIntent(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"You have reached the TurnOff intent. You said: {result.Query}"); //
            context.Wait(MessageReceived);
        }
    }
}
