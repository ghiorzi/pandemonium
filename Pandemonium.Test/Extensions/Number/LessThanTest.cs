using Xunit;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Number
{
    public class LessThanTest
    {
        [Fact]
        public void Should_Be_True_Given_A_Value_LessThan_1() 
        {
            Assert.True(((sbyte) 0).LessThan(1));
            Assert.True(((byte) 0).LessThan(1));
            Assert.True(((short) 0).LessThan(1));
            Assert.True(((ushort) 0).LessThan(1));
            Assert.True(((int) 0).LessThan(1));
            Assert.True(((uint) 0).LessThan(1));
            Assert.True(((long) 0).LessThan(1));
            Assert.True(((ulong) 0).LessThan(1));
            Assert.True(((float) 0).LessThan(1));
            Assert.True(((double) 0).LessThan(1));
            Assert.True(((decimal) 0).LessThan(1));
        }

        [Fact]
        public void Should_Be_False_Given_A_Value_Greater_Than_1() 
        {
            Assert.False(((sbyte) 2).LessThan(1));
            Assert.False(((byte) 2).LessThan(1));
            Assert.False(((short) 2).LessThan(1));
            Assert.False(((ushort) 2).LessThan(1));
            Assert.False(((int) 2).LessThan(1));
            Assert.False(((uint) 2).LessThan(1));
            Assert.False(((long) 2).LessThan(1));
            Assert.False(((ulong) 2).LessThan(1));
            Assert.False(((float) 2).LessThan(1));
            Assert.False(((double) 2).LessThan(1));
            Assert.False(((decimal) 2).LessThan(1));
        }
    }
}
