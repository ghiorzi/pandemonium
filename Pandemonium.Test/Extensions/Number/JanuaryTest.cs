using Xunit;
using System;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Number
{
    public class JanuaryTest
    {
        [Fact]
        public void Should_Be_True_Given_January_As_Month() 
        {
            DateTime date = 31.January(2020);

            Assert.True(date == new DateTime(2020, 1, 31));
        }

        [Fact]
        public void Should_Be_False_Given_July_As_Month() 
        {
            DateTime date = 31.January(2020);

            Assert.False(date == new DateTime(2020, 7, 31));
        }
    }
}
