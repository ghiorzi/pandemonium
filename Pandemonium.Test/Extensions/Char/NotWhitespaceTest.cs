using Xunit;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Char
{
    public class NotWhiteSpaceTest
    {
        [Fact]
        public void Should_Be_False_Given_A_Whitespace() => Assert.False(' '.NotWhitespace());

        [Fact]
        public void Should_Be_True_Given_A_Letter() => Assert.True('a'.NotWhitespace());
    }
}