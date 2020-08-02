
using Xunit;
using System;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Number
{
    public class AugustTest
    {
        [Fact]
        public void Should_Be_True_Given_August_As_Month() 
        {
            DateTime date = 28.August(2020);

            Assert.True(date == new DateTime(2020, 8, 28));
        }

        [Fact]
        public void Should_Be_False_Given_May_As_Month() 
        {
            DateTime date = 28.August(2020);

            Assert.False(date == new DateTime(2020, 7, 28));
        }
    }
}
