using Xunit;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Strings
{
    public class NotContainsTest
    {
        [Fact]
        public void Should_Contain()
        {
            bool result = "1234".NotContains("s", "a", "m", "1");

            Assert.False(result);
        }

        [Fact]
        public void Should_Not_Contain()
        {
            bool result = "1234".NotContains("s", "a", "m", "z");

            Assert.True(result);
        }
    }
}
