using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PerfectLifeWebService.Model;

namespace PerfectLifeWebService.Controllers
{
    [Route("api/[controller]")]
    public class WeightController : Controller
    {
        public WeightController(IWeightRepository repository)
        {

        }

        [HttpPost]
        public void Post([FromBody]string userName, [FromBody]int weight)
        {
        }

        [HttpGet]
        public IEnumerable<WeightRecord> Get(string user)
        {
            return new WeightRecord[]
            {
                new WeightRecord("user1", 80),
                new WeightRecord("user1", 79),
                new WeightRecord("user1", 78),
                new WeightRecord("user1", 77),
            };
        }
    }
}
