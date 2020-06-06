using Xunit;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Char
{
    public class DigitTest
    {
        [Theory]
        [InlineData('0')]
        [InlineData('1')]
        [InlineData('2')]
        [InlineData('3')]
        [InlineData('4')]
        [InlineData('5')]
        [InlineData('6')]
        [InlineData('7')]
        [InlineData('8')]
        [InlineData('9')]
        public void Should_Be_True_Given_A_Digit(char digit) => Assert.True(digit.Digit());

        [Fact]
        public void Should_Be_False_Given_A_Letter() => Assert.False('a'.Digit());
    }
}
