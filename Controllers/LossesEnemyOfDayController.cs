using Microsoft.AspNetCore.Mvc;
using КП.Model;
using КП.Clients;

namespace КП.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LossesEnemyOfDayController : ControllerBase
    {
        [HttpGet(Name = "LossesEnemyByDay")]
        public VideoOfDay Day(string Day)
        {
            LossesEnemyClient client = new LossesEnemyClient();
            return client.GetLossesEnemyByDayAsync(Day).Result;
        }
    }
}