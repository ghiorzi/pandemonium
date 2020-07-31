using Xunit;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Number
{
    public class GreaterThanTest
    {
        [Fact]
        public void Should_Be_True_Given_A_Value_GreaterThan_0() 
        {
            Assert.True(((sbyte) 1).GreaterThan(0));
            Assert.True(((byte) 1).GreaterThan(0));
            Assert.True(((short) 1).GreaterThan(0));
            Assert.True(((ushort) 1).GreaterThan(0));
            Assert.True(((int) 1).GreaterThan(0));
            Assert.True(((uint) 1).GreaterThan(0));
            Assert.True(((long) 1).GreaterThan(0));
            Assert.True(((ulong) 1).GreaterThan(0));
            Assert.True(((float) 1.0).GreaterThan(0));
            Assert.True(((double) 1.0).GreaterThan(0));
            Assert.True(((decimal) 1.0).GreaterThan(0));
        }

        [Fact]
        public void Should_Be_False_Given_A_Value_Less_Than_1() 
        {
            Assert.False(((sbyte) 0).GreaterThan(1));
            Assert.False(((byte) 0).GreaterThan(1));
            Assert.False(((short) 0).GreaterThan(1));
            Assert.False(((ushort) 0).GreaterThan(1));
            Assert.False(((int) 0).GreaterThan(1));
            Assert.False(((uint) 0).GreaterThan(1));
            Assert.False(((long) 0).GreaterThan(1));
            Assert.False(((ulong) 0).GreaterThan(1));
            Assert.False(((float) 0).GreaterThan(1));
            Assert.False(((double) 0).GreaterThan(1));
            Assert.False(((decimal) 0).GreaterThan(1));
        }
    }
}
