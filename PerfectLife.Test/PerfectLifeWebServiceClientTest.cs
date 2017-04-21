using System;
using Xunit;
using perfectlife.Services;

namespace PerfectLife.Test
{
    public class PerfectLifeWebServiceClientTest
    {
        [Fact]
        public void ShouldAddSingleRecord()
        {
            var service = new PerfectLifeWebServiceClient();


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
