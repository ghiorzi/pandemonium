using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Strings
{
    public class WhereTest
    {
        [Fact]
        public void Should_Get_Only_Numbers()
        {
            string text = "1 2 3 - sample";

            string number = text.Where(value => value.Number());

            Assert.Equal("123", number);
        }
    }
}
