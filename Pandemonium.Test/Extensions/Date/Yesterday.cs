using Xunit;
using Pandemonium;
using System;

namespace Pandemonium.Test.Functions.Date
{
    public class YesterdayTest
    {
        [Fact]
        public void Should_Be_Yesterday()
        {
            var date = DateTime.Now;
            var expected = date.Subtract(1);

            var tomorrow = date.Yesterday();

            Assert.Equal(expected, tomorrow);
        }

        [Fact]
        public void Should_Not_Be_Yesterday()
        {
            var date = DateTime.Now;
            var tomorrow = DateTime.Now.AddDays(1);

            var yesterday = date.Yesterday();

            Assert.False(yesterday == tomorrow);
        }
    }
}
