using Xunit;
using Pandemonium;
using System;

namespace Pandemonium.Test.Extensions.Date
{
    public class PastTest
    {
        [Fact]
        public void Should_Be_In_Past_Given_Yesterday()
        {
            var date = DateTime.Now;
            var yesterday = date.Subtract(1);

            bool result = date.Past();

            Assert.True(result);
        }

        [Fact]
        public void Should_Not_Be_In_Past_Given_Future_Date()
        {
            var date = DateTime.Now.AddDays(1);

            bool result = date.Past();

            Assert.False(result);
        }
    }
}
