using Xunit;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Char
{
    public class NotSeparatorTest
    {
        [Theory]
        [InlineData(' ')]
        public void Should_Be_False_Given_A_Separator(char separator) => Assert.False(separator.NotSeparator());

        [Fact]
        public void Should_Be_True_Given_A_Letter() => Assert.True('a'.NotPunctuation());
    }
}