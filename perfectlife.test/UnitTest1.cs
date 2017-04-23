using System;
using Xunit;
using perfectlife.Services;

namespace perfectlife.test
{
    public class PerfectLifeWebServiceClientTest
    {
        [Fact]
        public void ShouldAddSingleRecord()
        {
            var service = new PerfectLifeWebServiceClient();
            var resut = service.GetRecords("darek");
            Assert.Equal(1, resut.Result.Count);

        }

        [Fact]
        public void ShouldReadRecordCollection()
        {
            var service = new PerfectLifeWebServiceClient();
            var result = service.GetRecords("darek");

        }


    }

}
