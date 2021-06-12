using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Strings
{
    public class NotWhitespaceTest
    {
        [Fact]
        public void Should_Not_Be_Whitespace()
        {
            string text = "_";

            Assert.True(text.NotWhitespace());
        }
    }
}
