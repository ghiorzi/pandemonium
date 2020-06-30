using Xunit;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Char
{
    public class NotUpperTest
    {
        [Fact]
        public void Should_Be_True_Given_A_Lowercase_Letter() => Assert.True('a'.NotUpper());

        [Fact]
        public void Should_Be_False_Given_A_Uppercase_Letter() => Assert.False('A'.NotUpper());
    }
}
