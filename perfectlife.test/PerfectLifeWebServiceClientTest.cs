using System;
using Xunit;
using perfectlife.Services;

namespace perfectlife.test
{
    //Integration test - it hits real web service
    public class PerfectLifeWebServiceClientTest
    {
        [Fact]
        public void ShouldAddSingleRecord()
        {
            //TODO using tdd
        }

        [Fact]
        public void ShouldReadRecordCollection()
        {
            var service = new PerfectLifeWebServiceClient();
            var result = service.GetRecords("darek");
            Assert.Equal(1, result.Result.Count);
        }
    }

}
