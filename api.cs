using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace WapifyClient
{
    public class WapifyService
    {
        private const string BaseUrl = "https://app.wapify.net/api/";
        private const string ApiKey = "Your API Key";
        private const string InstanceKey = "Your Instance Key";

        private HttpClient _client;

        public WapifyService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(BaseUrl);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
        }

        public async Task<string> SendMessage(string number, string msg)
        {
            var postData = new Dictionary<string, string>
            {
                { "number", number },
                { "msg", msg },
                { "instance", InstanceKey },
                { "apikey", ApiKey }
            };

            var response = await _client.PostAsync("text-message.php", new FormUrlEncodedContent(postData));
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> SendMediaMessage(string number, string msg, string media)
        {
            var postData = new Dictionary<string, string>
            {
                { "number", number },
                { "msg", msg },
                { "media", media },
                { "instance", InstanceKey },
                { "apikey", ApiKey }
            };

            var response = await _client.PostAsync("media-message.php", new FormUrlEncodedContent(postData));
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> CreateGroup(string member, string groupName)
        {
            var postData = new Dictionary<string, string>
            {
                { "member", member },
                { "group_name", groupName },
                { "instance", InstanceKey },
                { "apikey", ApiKey }
            };

            var response = await _client.PostAsync("create-group.php", new FormUrlEncodedContent(postData));
            return await response.Content.ReadAsStringAsync();
        }

        public static void Main(string[] args)
        {
            var service = new WapifyService();
            // You can call the methods here and print the response, for example:
            // var response = await service.SendMessage("91xxxxxxxx", "Your Message");
            // Console.WriteLine(response);
        }
    }
}
