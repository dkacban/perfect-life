using System;
using Xunit;
using PerfectLifeWebService.Controllers;
using PerfectLifeWebService.Model;
using System.Collections.Generic;
using System.Linq;

namespace PerfectLifeWebService.Test
{
    public class WeightControllerTest
    {
        [Fact]
        public void ShouldAddAndRetrieveDataFromrepository()
        {
            var controller = new WeightController(new WeightRecordInMemoryRepository());
            controller.Post("user1", 80);
            controller.Post("user1", 79);
            controller.Post("user1", 78);
            controller.Post("user1", 90);

            IEnumerable<WeightRecord> weightRecords = controller.Get("user1").ToList();
            Assert.Equal(4, weightRecords.Count());
        }

        [Fact]
        public void ShouldAddAndRetrieveDataFromMongoDatabase()
        {
            var repository = new WeightRecordMongoRepository();
            var controller = new WeightController(repository);
            controller.Post("user1", 80);
            controller.Post("user1", 79);
            controller.Post("user1", 78);
            controller.Post("user2", 90);

            IEnumerable<WeightRecord> weightRecords = controller.Get("user1").ToList();
            Assert.Equal(3, weightRecords.Count());

            repository.DeleteRecords("user1");
            repository.DeleteRecords("user2");
        }
    }
}
