using Xunit;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Char
{
    public class NotLowerTest
    {
        [Fact]
        public void Should_Be_False_Given_A_Lowercase_Letter() => Assert.False('a'.NotLower());

        [Fact]
        public void Should_Be_True_Given_A_Uppercase_Letter() => Assert.True('A'.NotLower());
    }
}
