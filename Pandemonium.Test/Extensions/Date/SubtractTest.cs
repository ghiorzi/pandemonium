using Xunit;
using Pandemonium.Extensions;
using System;

namespace Pandemonium.Test.Extensions.Date
{
    public class SubtractTest
    {
        [Fact]
        public void Should_Subtract_One_Day()
        {
            var date = DateTime.Now;

            var yesterday = date.Subtract(1);

            Assert.Equal(yesterday, date.AddDays(-1));
        }

        [Fact]
        public void Should_Not_Be_Yesterday()
        {
            var date = DateTime.Now;

            var yesterday = date.Subtract(2);

            Assert.False(yesterday == date.AddDays(-1));
        }
    }
}
