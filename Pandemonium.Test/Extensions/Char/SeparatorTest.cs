using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Char
{
    public class SeparatorTest
    {
        [Fact]
        public void Should_Be_True_Given_A_Separator() => Assert.True(' '.Separator());

        [Fact]
        public void Should_Be_False_Given_A_Letter() => Assert.False('a'.Punctuation());
    }
}