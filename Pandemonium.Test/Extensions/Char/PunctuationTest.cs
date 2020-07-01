using Xunit;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Char
{
    public class PunctuationTest
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
        public void Should_Be_True_Given_A_Punctuation(char punctuation) => Assert.True(punctuation.Punctuation());

        [Fact]
        public void Should_Be_False_Given_A_Letter() => Assert.False('a'.Punctuation());
    }
}
