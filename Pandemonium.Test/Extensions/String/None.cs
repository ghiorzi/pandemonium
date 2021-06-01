using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Strings
{
    public class NoneTest
    {
        [Fact]
        public void Should_Have_Sample_In_Values()
        {
            bool result = "sample".None("s", "a", "m", "sample");

            Assert.False(result);
        }

        [Fact]
        public void Should_Not_Have_Sample_In_Values()
        {
            bool result = "sample".None("s", "a", "m", "samplesss");

            Assert.True(result);
        }
    }
}
