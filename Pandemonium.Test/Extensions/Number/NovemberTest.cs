
using Xunit;
using System;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Number
{
    public class NovemberTest
    {
        [Fact]
        public void Should_Be_True_Given_November_As_Month() 
        {
            DateTime date = 28.November(2020);

            Assert.True(date == new DateTime(2020, 11, 28));
        }

        [Fact]
        public void Should_Be_False_Given_July_As_Month() 
        {
            DateTime date = 28.November(2020);

            Assert.False(date == new DateTime(2020, 7, 28));
        }
    }
}
