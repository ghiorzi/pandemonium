using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Boolean
{
    public class AndTest
    {
        [Fact]
        public void Should_Be_True_Given_2_True_Values() 
            => Assert.True(true.And(true));

        [Theory]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void Should_Be_False_When_Both_Values_Are_Not_True_At_Same_Time(bool firstValue, bool secondValue)
            => Assert.False(firstValue.And(secondValue));
    }
}
