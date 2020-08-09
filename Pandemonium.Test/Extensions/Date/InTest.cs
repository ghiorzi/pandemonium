using Xunit;
using Pandemonium.Extensions;
using System;
using System.Collections.Generic;

namespace Pandemonium.Test.Extensions.Date
{
    public class InTest
    {
        [Fact]
        public void Should_Be_In()
        {
            var dates = new List<DateTime>();

            // yeah, i'm lazy
            for (int i = 3; i <= 7; i++)
                dates.Add(new DateTime(2020, 8, i));

            bool result = new DateTime(2020, 8, 5).In(dates.ToArray());

            Assert.True(result);
        }

        [Fact]
        public void Should_Not_Be_Weekend_Day()
        {
            var dates = new List<DateTime>();

            // yeah, i'm lazy
            for (int i = 3; i <= 7; i++)
                dates.Add(new DateTime(2020, 8, i));

            bool result = new DateTime(2020, 8, 2).In(dates.ToArray());

            Assert.False(result);
        }
    }
}
