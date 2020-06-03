using Xunit;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Boolean
{
    public class AndTest
    {
        [Fact]
        public void Should_Be_True_Given_2_True_Values() => Assert.True(true.And(true));
    }
}
