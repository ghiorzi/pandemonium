
using Xunit;
using System;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Number
{
    public class JuneTest
    {
        [Fact]
        public void Should_Be_True_Given_June_As_Month() 
        {
            DateTime date = 28.June(2020);

            Assert.True(date == new DateTime(2020, 6, 28));
        }

        [Fact]
        public void Should_Be_False_Given_July_As_Month() 
        {
            DateTime date = 28.June(2020);

            Assert.False(date == new DateTime(2020, 7, 28));
        }
    }
}
