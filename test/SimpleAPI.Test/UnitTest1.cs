using SimpleAPI.Controllers;
using System;
using Xunit;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller;

        public UnitTest1()
        {
            controller = new WeatherForecastController();
        }

        [Fact]
        public void Test1()
        {
            var expected = controller.Put(10);

            Assert.Equal("Val", expected.Value);
        }
    }
}
