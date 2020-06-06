using Xunit;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Char
{
    public class LetterOrDigitTest
    {
        [Theory]
        [InlineData('a')]
        [InlineData('b')]
        [InlineData('c')]
        [InlineData('d')]
        [InlineData('e')]
        [InlineData('f')]
        [InlineData('g')]
        [InlineData('h')]
        [InlineData('i')]
        [InlineData('j')]
        [InlineData('k')]
        [InlineData('l')]
        [InlineData('m')]
        [InlineData('n')]
        [InlineData('o')]
        [InlineData('p')]
        [InlineData('q')]
        [InlineData('r')]
        [InlineData('s')]
        [InlineData('t')]
        [InlineData('u')]
        [InlineData('v')]
        [InlineData('x')]
        [InlineData('w')]
        [InlineData('y')]
        [InlineData('z')]
        public void Should_Be_True_Given_A_Letter(char letter) => Assert.True(letter.LetterOrDigit());

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
        public void Should_Be_True_Given_A_Digit(char digit) => Assert.True(digit.LetterOrDigit());

        [Fact]
        public void Should_Be_False_Given_A_Operator() => Assert.False('+'.Letter());
    }
}
