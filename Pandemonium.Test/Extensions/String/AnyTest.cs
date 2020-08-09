using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Strings
{
    public class AnyTest
    {
        [Fact]
        public void Should_Have_Sample_In_Values()
        {
            bool result = "sample".Any("s", "a", "m", "sample");

            Assert.True(result);
        }

        [Fact]
        public void Should_Not_Have_Sample_In_Values()
        {
            bool result = "sample".Any("s", "a", "m", "samplesss");

            Assert.False(result);
        }
    }
}
