using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Functions.Char
{
    public class UpperTest
    {
        [Fact]
        public void Should_Be_False_Given_A_Lowercase_Letter() 
            => Assert.False('a'.Upper());

        [Fact]
        public void Should_Be_True_Given_A_Uppercase_Letter() 
            => Assert.True('A'.Upper());
    }
}
