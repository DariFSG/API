using КП.Constant;
using КП.Model;
using Newtonsoft.Json;
using System.Net.Http;

namespace КП.Clients
{
    public class LossesEnemyClient
    {
        public async Task<VideoOfDay> GetLossesEnemyByDayAsync(string Day)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://youtube138.p.rapidapi.com/search/?q=%D0%92%D1%82%D1%80%D0%B0%D1%82%D0%B8%20%D0%B2%D0%BE%D1%80%D0%BE%D0%B3%D0%B0%20%7C%20{Day}%20%D0%B4%D0%B5%D0%BD%D1%8C%20%D0%B2%D1%96%D0%B8%CC%86%D0%BD%D0%B8%20%D0%B2%20%D0%A3%D0%BA%D1%80%D0%B0%D1%96%CC%88%D0%BD%D1%96"),
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
