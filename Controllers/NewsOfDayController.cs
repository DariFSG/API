using Microsoft.AspNetCore.Mvc;
using КП.Model;
using КП.Clients;

namespace КП.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsOfDayController : ControllerBase
    {
        [HttpGet(Name = "NewsByDay")]
        public NewsOfDay Day(string Day)
        {
            NewsClient client = new NewsClient();
            return client.GetNewsByDayAsync(Day).Result;
        }
    }
}
