using Xunit;
using Pandemonium;
using System;

namespace Pandemonium.Test.Extensions.Date
{
    public class WeekTest
    {
        [Fact]
        public void Should_Be_Week_Day()
        {
            // from monday to friday
            for(int i = 3; i <= 7; i++)
            {
                var date = new DateTime(2020, 8, i);
                Assert.True(date.Weekday());
            }
        }

        [Fact]
        public void Should_Not_Be_Week_Day()
        {
            // from saturday to sunday
            for(int i = 8; i <= 9; i++)
            {
                var date = new DateTime(2020, 8, i);
                Assert.False(date.Weekday());
            }
        }
    }
}
