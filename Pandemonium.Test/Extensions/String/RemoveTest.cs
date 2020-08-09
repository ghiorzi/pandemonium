using Xunit;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Strings
{
    public class RemoveTest
    {
        [Fact]
        public void Should_Remove_Numbers()
        {
            string text = "123 - sample";

            string number = text.Remove(value => value.Number());

            Assert.Equal(" - sample", number);
        }
    }
}
