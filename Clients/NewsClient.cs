using КП.Constant;
using КП.Model;
using Newtonsoft.Json;
using System.Net.Http;

namespace КП.Clients
{
    public class NewsClient
    {        
        public async Task<NewsOfDay> GetNewsByDayAsync(string Day)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://extract-news.p.rapidapi.com/v0/article?url=https%3A%2F%2Fnovynarnia.com%2Fhronika-oborony-ukrayiny-den-{Day}"),
                Headers =
                {
                 { "X-RapidAPI-Key", "ef0141e423msh4122623943217d0p1a2fb0jsna0eb7d2e407b" },
                 { "X-RapidAPI-Host", "extract-news.p.rapidapi.com" },
                 },
            };
            var response = await client.SendAsync(request);
            
            response.EnsureSuccessStatusCode();

            var body = await response.Content.ReadAsStringAsync();            

            return JsonConvert.DeserializeObject<NewsOfDay>(body);
        }
    }
}
