using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Bot.Connector;
using Microsoft.Extensions.Configuration;

namespace bot.server.Controllers
{
    [Route("api/[controller]")]
    public class MessagesController : Controller
    {
        private readonly IConfigurationRoot configuration;

        public MessagesController(IConfigurationRoot configuration)
        {
            this.configuration = configuration;
        }

//        [Authorize(Roles = "Bot")]
        [HttpPost]
        public virtual async Task<ActionResult> Post([FromBody] Activity activity)
        {
            var appCredentials = new MicrosoftAppCredentials(this.configuration);
            
            var client = new ConnectorClient(new Uri(activity.ServiceUrl), appCredentials);

            var reply = activity.CreateReply();

            if (activity.Type == ActivityTypes.Message)
                reply.Text = $"echo: {activity.Text}";
            else
                reply.Text = $"activity type: {activity.Type}";

            await client.Conversations.ReplyToActivityAsync(reply);

            return Ok();
        }

    }

}