using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Functions.Strings
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
