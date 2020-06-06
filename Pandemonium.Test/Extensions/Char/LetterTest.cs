using Xunit;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Char
{
    public class LetterTest
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
        public void Should_Be_True_Given_A_Letter(char letter) => Assert.True(letter.Letter());

        [Fact]
        public void Should_Be_False_Given_A_Number() => Assert.False('1'.Letter());
    }
}
