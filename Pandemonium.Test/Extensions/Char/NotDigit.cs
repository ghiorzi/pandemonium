using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Functions.Char
{
    public class NotDigitTest
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
        public void Should_Not_Be_A_Digit(char digit) 
            => Assert.False(digit.NotDigit());

        [Fact]
        public void Should_Be_A_Letter() 
            => Assert.True('a'.NotDigit());
    }
}
