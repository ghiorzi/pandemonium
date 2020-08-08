using Xunit;
using Pandemonium.Extensions;
using System;

namespace Pandemonium.Test.Extensions.Date
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
            var yesteday = DateTime.Now.Subtract(1);

            var tomorrow = date.Tomorrow();

            Assert.False(yesteday == tomorrow);
        }
    }
}
