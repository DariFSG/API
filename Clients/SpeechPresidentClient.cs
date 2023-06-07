using КП.Constant;
using КП.Model;
using Newtonsoft.Json;
using System.Net.Http;

namespace КП.Clients
{
    public class SpeechPresidentClient
    {
        public async Task<VideoOfDay> GetSpeechPresidentByDayAsync(string Day)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://youtube138.p.rapidapi.com/search/?q={Day}%20%D0%B4%D0%B5%D0%BD%D1%8C%20%D0%B2%D1%96%D0%B9%D0%BD%D0%B8.%20%D0%97%D0%B2%D0%B5%D1%80%D0%BD%D0%B5%D0%BD%D0%BD%D1%8F%20%D0%9F%D1%80%D0%B5%D0%B7%D0%B8%D0%B4%D0%B5%D0%BD%D1%82%D0%B0%20%D0%A3%D0%BA%D1%80%D0%B0%D1%97%D0%BD%D0%B8%20%D0%92%D0%BE%D0%BB%D0%BE%D0%B4%D0%B8%D0%BC%D0%B8%D1%80%D0%B0%20%D0%97%D0%B5%D0%BB%D0%B5%D0%BD%D1%81%D1%8C%D0%BA%D0%BE%D0%B3%D0%BE%20%D0%B4%D0%BE%20%D1%83%D0%BA%D1%80%D0%B0%D1%97%D0%BD%D1%86%D1%96%D0%B2"),
                Headers =
                {
                    { "X-RapidAPI-Key", "ef0141e423msh4122623943217d0p1a2fb0jsna0eb7d2e407b" },
                    { "X-RapidAPI-Host", "youtube138.p.rapidapi.com" },
                },
            };
            
            var response = await client.SendAsync(request);

            response.EnsureSuccessStatusCode();

            var body = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<VideoOfDay>(body);
        }
    }
}