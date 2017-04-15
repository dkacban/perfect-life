using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PerfectLifeWebService.Model;

namespace PerfectLifeWebService.Controllers
{
    [Route("api/[controller]")]
    public class WeightController : Controller
    {
        IWeightRecordRepository _repository;

        public WeightController() : this(new WeightRecordInMemoryRepository())
        {
        }

        public WeightController(IWeightRecordRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public void Post([FromBody]string userName, [FromBody]int weight)
        {
            _repository.AddRecord(new WeightRecord(userName, weight));
        }

        [HttpGet]
        public IEnumerable<WeightRecord> Get(string userName)
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
