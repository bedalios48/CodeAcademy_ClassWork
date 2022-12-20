using App1121.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace App1121.Services
{
    public class OpenRouteProxyService : IOpenRouteProxyService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public OpenRouteProxyService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<string> GetCityInfo(string city)
        {
            var httpClient = _httpClientFactory.CreateClient("OpenRoute");
            var endpoint = "geocode/search?" + "api_key=" + "5b3ce3597851110001cf62484b4c0daa7cba4223afa32b3433564034"
                + "&text=" + city;

            var reponse = await httpClient.GetAsync(endpoint);
            if (reponse.IsSuccessStatusCode)
            {
                var content = await reponse.Content.ReadAsStringAsync();
                var res = JObject.Parse(content);
                var fe = res.SelectToken("features");
                foreach(var token in fe.Children())
                {
                    var country = token.SelectToken("country");
                }
                return content;
            }

            return null;
        }
    }
}
