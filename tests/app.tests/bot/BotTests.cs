using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Bot.Client;
using Microsoft.Bot.Connector;
using Microsoft.Rest;
using Newtonsoft.Json;
using Xunit;

namespace app.tests.bot
{
    public class BotTests
    {

        [Fact]
        public async void can_send_message()
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri("https://login.microsoftonline.com/botframework.com/oauth2/v2.0/token");
                var formData = new Dictionary<string, string>
                {
                    {"grant_type", "client_credentials"},
                    {"client_id", "53e49964-222e-468c-91f4-6bd8b6a2c03d"},
                    {"client_secret", "WaNBecgkBAJTqLass0atVGA"},
                    {"scope", "https://api.botframework.com/.default"}
                };
                var response = await client.PostAsync(uri, new FormUrlEncodedContent(formData));
                var body = await response.Content.ReadAsStringAsync();
                var accessToken = JsonConvert.DeserializeObject<dynamic>(body).access_token;
                
                var botUri = new Uri("http://localhost:5000/api/messages");
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");
                client.DefaultRequestHeaders.Add("Content-Type", "application/json");
                
                var activity = Activity.CreateMessageActivity();
                activity.Text = "hola bot";
                
                var req = JsonConvert.SerializeObject(activity);


                var res = await client.PostAsync(botUri, new StringContent(req));
                var test = "123";

            }
            
        }
        
    }
}