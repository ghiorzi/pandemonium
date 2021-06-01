using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Number
{
    public class NegativeTest
    {
        [Fact]
        public void Should_Be_True_Given_Negative_Number() 
        {
            Assert.True(((sbyte) -1).Negative());
            Assert.True(((short) -1).Negative());
            Assert.True(((int) -1).Negative());
            Assert.True(((long) -1).Negative());
            Assert.True(((float) -1.0).Negative());
            Assert.True(((double) -1.0).Negative());
            Assert.True(((decimal) -1.0).Negative());
        }

        [Fact]
        public void Should_Be_False_Given_Positive_Number() 
        {
            Assert.False(((sbyte) 1).Negative());
            Assert.False(((short) 1).Negative());
            Assert.False(((int) 1).Negative());
            Assert.False(((long) 1).Negative());
            Assert.False(((float) 1.0).Negative());
            Assert.False(((double) 1.0).Negative());
            Assert.False(((decimal) 1.0).Negative());
        }
    }
}
