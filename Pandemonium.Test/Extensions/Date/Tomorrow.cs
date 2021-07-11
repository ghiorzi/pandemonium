using Xunit;
using Pandemonium;
using System;

namespace Pandemonium.Test.Functions.Date
{
    public class TomorrowTest
    {
        [Fact]
        public void Should_Be_Tomorrow()
        {
            var date = DateTime.Now;
            var expected = date.AddDays(1);

            var tomorrow = date.Tomorrow();

            Assert.Equal(expected, tomorrow);
        }

        [Fact]
        public void Should_Not_Be_Tomorrow()
        {
            var date = DateTime.Now;
            var yesterday = DateTime.Now.Subtract(1);

            var tomorrow = date.Tomorrow();

            Assert.False(yesterday == tomorrow);
        }
    }
}
