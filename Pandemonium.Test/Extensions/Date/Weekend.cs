using Xunit;
using Pandemonium;
using System;

namespace Pandemonium.Test.Functions.Date
{
    public class WeekendTest
    {
        [Fact]
        public void Should_Be_Weekend_Day()
        {
            // from saturday to sunday
            for (int i = 8; i <= 9; i++)
            {
                var date = new DateTime(2020, 8, i);
                Assert.True(date.Weekend());
            }
        }

        [Fact]
        public void Should_Not_Be_Weekend_Day()
        {
            // from monday to friday
            for (int i = 3; i <= 7; i++)
            {
                var date = new DateTime(2020, 8, i);
                Assert.False(date.Weekend());
            }
        }
    }
}
