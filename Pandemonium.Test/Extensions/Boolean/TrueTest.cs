using Xunit;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Boolean
{
    public class TrueTest
    {
        [Fact]
        public void Should_Be_True_Given_True_Valus() => Assert.True(true.True());

        [Fact]
        public void Should_Be_False_Given_False_Valus() => Assert.False(false.True());
    }
}
