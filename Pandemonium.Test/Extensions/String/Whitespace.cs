using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Strings
{
    public class WhitespaceTest
    {
        [Fact]
        public void Should_Be_Whitespace()
        {
            string text = " ";

            Assert.True(text.Whitespace());
        }
    }
}
