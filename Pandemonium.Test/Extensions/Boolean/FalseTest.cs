using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Boolean
{
    public class FalseTest
    {
        [Fact]
        public void Should_Be_True_Given_False_Valus() 
            => Assert.True(false.False());

        [Fact]
        public void Should_Be_False_Given_True_Valus() 
            => Assert.False(true.False());
    }
}
