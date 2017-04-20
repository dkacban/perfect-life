using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PerfectLifeWebService.Model;

namespace PerfectLifeWebService.Controllers
{
    [Route("api/[controller]")]
    public class WeightController : Controller
    {
        IWeightRecordRepository _repository;

        public WeightController(IWeightRecordRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public void Post(string userName, int weight)
        {
            _repository.AddRecord(new WeightRecord(userName, weight));
        }

        [HttpGet]
        public IEnumerable<WeightRecord> Get(string userName)
        {
            return _repository.GetRecords(userName);
        }
    }
}
