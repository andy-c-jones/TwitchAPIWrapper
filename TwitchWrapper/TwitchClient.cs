using System;
using RestSharp;

namespace TwitchWrapper
{
    public class TwitchClient
    {
        private readonly RestClient _client;

        public TwitchClient()
        {
            _client = new RestClient("https://api.twitch.tv/kraken");
        }

        public TwitchRequest BuildRequest(string resource)
        {
            return new TwitchRequest(resource);
        }

        public T ExecuteRequest<T>(TwitchRequest request) where T : new()
        {
            var req = new RestRequest(request.Resource);
            return _client.Execute<T>(req).Data;
        }
    }
}
