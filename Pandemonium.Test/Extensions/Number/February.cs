using Xunit;
using System;
using System.Globalization;
using Pandemonium;

namespace Pandemonium.Test.Functions.Number
{
    public class FebruaryTest
    {
        [Fact]
        public void Should_Be_True_Given_February_As_Month() 
        {
            DateTime date = 28.February(2020);
            DateTime dateWithCalender = 28.February(2020, CultureInfo.InvariantCulture.Calendar);
            DateTime dateWithTime = 28.February(2020, 0, 0, 0);
            DateTime dateWithTimeAndKind = 28.February(2020, 0, 0, 0, DateTimeKind.Utc);
            DateTime dateWithTimeAndCalender = 28.February(2020, 0, 0, 0, CultureInfo.InvariantCulture.Calendar);
            DateTime dateWithMilliseconds = 28.February(2020, 0, 0, 0, 0);
            DateTime dateWithMillisecondsAndKind = 28.February(2020, 0, 0, 0, 0, DateTimeKind.Utc);

            Assert.True(date == new DateTime(2020, 2, 28));
            Assert.True(dateWithCalender == new DateTime(2020, 2, 28));
            Assert.True(dateWithTime == new DateTime(2020, 2, 28));
            Assert.True(dateWithTimeAndKind == new DateTime(2020, 2, 28));
            Assert.True(dateWithTimeAndCalender == new DateTime(2020, 2, 28));
            Assert.True(dateWithMilliseconds == new DateTime(2020, 2, 28));
            Assert.True(dateWithMillisecondsAndKind == new DateTime(2020, 2, 28));
        }

        [Fact]
        public void Should_Be_False_Given_July_As_Month() 
        {
            DateTime date = 28.February(2020);

            Assert.NotEqual(date, new DateTime(2020, 7, 28));
        }
    }
}
