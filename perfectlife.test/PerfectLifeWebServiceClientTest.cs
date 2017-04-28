using System;
using Xunit;
using perfectlife.Services;
using System.Net;

namespace perfectlife.test
{
    //Integration test - it hits real web service
    public class PerfectLifeWebServiceClientTest
    {
        [Fact]
        public void NumberOfRecordsShouldIncreaseWhenIAddRecord()
        {
            var userName = "test-user";
            var service = new PerfectLifeWebServiceClient();

            var records1 = service.GetRecords(userName).Result.Count;

            var record = new WeightRecord(userName, 80);
            var result = service.AddRecord(record);
            Assert.Equal(HttpStatusCode.OK, result.Result);

            var records2 = service.GetRecords(userName).Result.Count;
            Assert.Equal(records1 + 1, records2);
        }
    }

}
