using Xunit;
using System;

namespace Pandemonium.Test.Extensions.Date
{
    public class BetweenTest
    {
        [Fact]
        public void Should_Be_Between_10_January_12_January_2020()
        {
            var date = new DateTime(2020, 1, 11); 
            var @this = new DateTime(2020, 1, 10); 
            var that = new DateTime(2020, 1, 12); 

            bool result = date.Between(@this, that);

            Assert.True(result);
        }

        [Fact]
        public void Should_Not_Be_Between_10_January_12_January_2020()
        {
            var date = new DateTime(2020, 1, 13); 
            var @this = new DateTime(2020, 1, 10); 
            var that = new DateTime(2020, 1, 12); 

            bool result = date.Between(@this, that);

            Assert.False(result);
        }
    }
}
