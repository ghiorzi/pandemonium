using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Boolean
{
    public class TrueTest
    {
        [Fact]
        public void Should_Be_True_Given_True_Value() 
            => Assert.True(true.True());

        [Fact]
        public void Should_Be_False_Given_False_Value() 
            => Assert.False(false.True());
    }
}
