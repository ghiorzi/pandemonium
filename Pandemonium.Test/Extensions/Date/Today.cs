using Xunit;
using Pandemonium;
using System;

namespace Pandemonium.Test.Functions.Date
{
    public class TodayTest
    {
        [Fact]
        public void Should_Be_Today()
        {
            var date = DateTime.Now;

            bool result = date.Today();

            Assert.True(result);
        }

        [Fact]
        public void Should_Not_Be_Today_Given_Future_Date()
        {
            var date = DateTime.Now.AddDays(1);

            bool result = date.Today();

            Assert.False(result);
        }
    }
}
