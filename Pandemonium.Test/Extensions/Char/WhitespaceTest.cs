using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Char
{
    public class WhiteSpaceTest
    {
        [Fact]
        public void Should_Be_True_Given_A_Whitespace() => Assert.True(' '.Whitespace());

        [Fact]
        public void Should_Be_False_Given_A_Letter() => Assert.False('a'.Whitespace());
    }
}