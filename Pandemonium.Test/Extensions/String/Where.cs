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

        [Fact]
        public void Should_Get_Only_Numbers_Query_Expression()
        {
            string text = "1 2 3 - sample";

            string number = 
                from x in text
                where x.Number()
                select x;

            Assert.Equal("123", number);
        }
    }
}
