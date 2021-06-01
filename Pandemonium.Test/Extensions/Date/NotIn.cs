using Xunit;
using Pandemonium;
using System;
using System.Collections.Generic;

namespace Pandemonium.Test.Extensions.Date
{
    public class NotInTest
    {
        [Fact]
        public void Should_Be_Not_In()
        {
            var dates = new List<DateTime>();

            // yeah, i'm lazy
            for (int i = 3; i <= 7; i++)
                dates.Add(new (2020, 8, i));

            bool result = new DateTime(2020, 8, 15).NotIn(dates.ToArray());

            Assert.True(result);
        }

        [Fact]
        public void Should_Be_In()
        {
            var dates = new List<DateTime>();

            // yeah, i'm lazy
            for (int i = 3; i <= 7; i++)
                dates.Add(new (2020, 8, i));

            bool result = new DateTime(2020, 8, 5).NotIn(dates.ToArray());

            Assert.False(result);
        }
    }
}
