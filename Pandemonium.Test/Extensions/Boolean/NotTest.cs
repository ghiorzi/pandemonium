using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Boolean
{
    public class NotTest
    {
        [Fact]
        public void Should_Be_True_Given_False_Value() => Assert.True(false.Not());

        [Fact]
        public void Should_Be_False_Given_True_Value() => Assert.False(true.Not());
    }
}
