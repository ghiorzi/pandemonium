using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Functions.Strings
{
    public class RemoveTest
    {
        [Fact]
        public void Should_Remove_Numbers()
        {
            string text = "123 - sample";

            string number = text.Exclude(value => value.Number());

            Assert.Equal(" - sample", number);
        }
    }
}
