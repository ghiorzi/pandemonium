using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Char
{
    public class LowerTest
    {
        [Fact]
        public void Should_Be_A_Lowercase_Letter() 
            => Assert.True('a'.Lower());

        [Fact]
        public void Should_An_Uppercase_Letter() 
            => Assert.False('A'.Lower());
    }
}
