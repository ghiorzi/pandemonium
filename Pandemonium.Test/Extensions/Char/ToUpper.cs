using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Functions.Char
{
    public class ToUpperTest
    {
        [Fact]
        public void Should_Be_True_Given_A_Lowercase_Letter() 
            => Assert.True('a'.ToUpper() == 'A');
    }
}
