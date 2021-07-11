using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Functions.Strings
{
    public class NumericTest
    {
        [Fact]
        public void Should_Be_Numeric()
            => Assert.True("1234".Numeric());

        [Fact]
        public void Should_Not_Be_Numeric()
            => Assert.False("1value2".Numeric());
    }
}
