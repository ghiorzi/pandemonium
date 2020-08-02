
using Xunit;
using System;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Number
{
    public class DecemberTest
    {
        [Fact]
        public void Should_Be_True_Given_December_As_Month() 
        {
            DateTime date = 28.December(2020);

            Assert.True(date == new DateTime(2020, 12, 28));
        }

        [Fact]
        public void Should_Be_False_Given_July_As_Month() 
        {
            DateTime date = 28.December(2020);

            Assert.False(date == new DateTime(2020, 7, 28));
        }
    }
}
