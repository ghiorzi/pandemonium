using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Strings
{
    public class EmptyTest
    {
        [Fact]
        public void Should_Be_Empty()
        {
            string value = null;

            Assert.True("".Empty());
            Assert.True(string.Empty.Empty());
            Assert.True(value.Empty());
        }

        [Fact]
        public void Should_Not_Be_Empty()
            => Assert.False("value".Empty());
    }
}
