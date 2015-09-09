using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.WebHooks;
using Newtonsoft.Json.Linq;

namespace WebHookServer.WebHookReceivers.Handlers
{
    public class GitHubHandler : WebHookHandler
    {
        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context)
        {
            JObject json = context.GetDataOrDefault<JObject>();

            return Task.FromResult(true);
        }
    }
}