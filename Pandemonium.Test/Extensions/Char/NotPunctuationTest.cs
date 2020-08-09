using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Char
{
    public class NotPunctuationTest
    {
        [Theory]
        [InlineData(':')]
        [InlineData(',')]
        [InlineData('—')]
        [InlineData('!')]
        [InlineData('-')]
        [InlineData('.')]
        [InlineData('?')]
        [InlineData(';')]
        public void Should_Be_False_Given_A_Punctuation(char punctuation) => Assert.False(punctuation.NotPunctuation());

        [Fact]
        public void Should_Be_True_Given_A_Letter() => Assert.True('a'.NotPunctuation());
    }
}
