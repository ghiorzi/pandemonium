using Xunit;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Number
{
    public class PositiveTest
    {
        [Fact]
        public void Should_Be_True_Given_Positive_Number() 
        {
            Assert.True(((sbyte) 1).Positive());
            Assert.True(((short) 1).Positive());
            Assert.True(((int) 1).Positive());
            Assert.True(((long) 1).Positive());
            Assert.True(((float) 1.0).Positive());
            Assert.True(((double) 1.0).Positive());
            Assert.True(((decimal) 1.0).Positive());
        }

        [Fact]
        public void Should_Be_False_Given_Negative_Number() 
        {
            Assert.False(((sbyte) -1).Positive());
            Assert.False(((short) -1).Positive());
            Assert.False(((int) -1).Positive());
            Assert.False(((long) -1).Positive());
            Assert.False(((float) -1.0).Positive());
            Assert.False(((double) -1.0).Positive());
            Assert.False(((decimal) -1.0).Positive());
        }
    }
}
