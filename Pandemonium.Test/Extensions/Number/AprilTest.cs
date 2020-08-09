using Xunit;
using System;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Number
{
    public class AprilTest
    {
        [Fact]
        public void Should_Be_True_Given_April_As_Month() 
        {
            DateTime date = 28.April(2020);

            Assert.True(date == new DateTime(2020, 4, 28));
        }

        [Fact]
        public void Should_Be_False_Given_July_As_Month() 
        {
            DateTime date = 28.April(2020);

            Assert.False(date == new DateTime(2020, 7, 28));
        }
    }
}
