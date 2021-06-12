using Xunit;
using System;
using System.Globalization;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Number
{
    public class JanuaryTest
    {
        [Fact]
        public void Should_Be_January() 
        {
            DateTime date = 31.January(2020);
            DateTime dateWithCalender = 31.January(2020, CultureInfo.InvariantCulture.Calendar);
            DateTime dateWithTime = 31.January(2020, 0, 0, 0);
            DateTime dateWithTimeAndKind = 31.January(2020, 0, 0, 0, DateTimeKind.Utc);
            DateTime dateWithTimeAndCalender = 31.January(2020, 0, 0, 0, CultureInfo.InvariantCulture.Calendar);
            DateTime dateWithMilliseconds = 31.January(2020, 0, 0, 0, 0);
            DateTime dateWithMillisecondsAndKind = 31.January(2020, 0, 0, 0, 0, DateTimeKind.Utc);

            Assert.True(date == new DateTime(2020, 1, 31));
            Assert.True(dateWithCalender == new DateTime(2020, 1, 31));
            Assert.True(dateWithTime == new DateTime(2020, 1, 31));
            Assert.True(dateWithTimeAndKind == new DateTime(2020, 1, 31));
            Assert.True(dateWithTimeAndCalender == new DateTime(2020, 1, 31));
            Assert.True(dateWithMilliseconds == new DateTime(2020, 1, 31));
            Assert.True(dateWithMillisecondsAndKind == new DateTime(2020, 1, 31));
        }

        [Fact]
        public void Should_Be_False_Given_July_As_Month() 
        {
            DateTime date = 31.January(2020);

            Assert.NotEqual(date, new DateTime(2020, 7, 31));
        }
    }
}
