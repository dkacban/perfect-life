using System;
using Xunit;
using PerfectLifeWebService.Controllers;

namespace PerfectLifeWebService.Test
{
    public class WeightControllerTest
    {
        [Fact]
        public void ShouldAddAndRetrieveDataFromrepository()
        {
            var controller = new WeightController();
            controller.Post("user1", 80);
        }
    }
}
