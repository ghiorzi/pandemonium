using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Char
{
    public class ToLowerTest
    {
        [Fact]
        public void Should_Be_True_Given_A_Uppercase_Letter() 
            => Assert.True('A'.ToLower() == 'a');
    }
}
