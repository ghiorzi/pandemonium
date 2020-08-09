using Xunit;
using Pandemonium.Extensions;
using System;

namespace Pandemonium.Test.Extensions.Date
{
    public class FutureTest
    {
        [Fact]
        public void Should_Be_In_Future_Given_Tomorrow()
        {
            var date = DateTime.Now;
            var tomorrow = date.AddDays(1);

            bool result = tomorrow.Future();

            Assert.True(result);
        }

        [Fact]
        public void Should_Not_Be_In_Future_Given_Present_Date()
        {
            var date = DateTime.Now;

            bool result = date.Future();

            Assert.False(result);
        }
    }
}
