using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Strings
{
    public class NotNumericTest
    {
        [Fact]
        public void Should_Be_Numeric()
            => Assert.False("1234".NotNumeric());

        [Fact]
        public void Should_Not_Be_Numeric()
            => Assert.True("1value2".NotNumeric());
    }
}
