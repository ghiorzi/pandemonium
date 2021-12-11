using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Functions.Strings
{
    public class ConcatTest
    {
        [Fact]
        public void Should_Concat()
        {
            string text = "123";

            string value = text.Concat(" - sample");

            Assert.Equal("123 - sample", value);
        }
    }
}
