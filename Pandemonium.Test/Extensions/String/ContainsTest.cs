using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Strings
{
    public class ContainsTest
    {
        [Fact]
        public void Should_Contain()
        {
            bool result = "1234".Contains("s", "a", "m", "1");

            Assert.True(result);
        }

        [Fact]
        public void Should_Not_Contain()
        {
            bool result = "1234".Contains("s", "a", "m", "z");

            Assert.False(result);
        }
    }
}
