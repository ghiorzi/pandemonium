using Xunit;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Boolean
{
    public class OrTest
    {

        [Fact]
        public void Should_Be_False_When_Both_Values_Are_False() => Assert.False(false.Or(false));

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        public void Should_Be_True_Given_False_Value(bool firstValue, bool secondValue) 
        {
            Assert.True(firstValue.Or(secondValue));
        }
    }
}
