using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Number
{
    public class NotEqualToTest
    {
        [Fact]
        public void Should_Be_True_Given_A_Value_Not_Equal_To_0() 
        {
            Assert.True(((sbyte) 1).NotEqualTo(0));
            Assert.True(((byte) 1).NotEqualTo(0));
            Assert.True(((short) 1).NotEqualTo(0));
            Assert.True(((ushort) 1).NotEqualTo(0));
            Assert.True(((int) 1).NotEqualTo(0));
            Assert.True(((uint) 1).NotEqualTo(0));
            Assert.True(((long) 1).NotEqualTo(0));
            Assert.True(((ulong) 1).NotEqualTo(0));
            Assert.True(((float) 1).NotEqualTo(0));
            Assert.True(((double) 1).NotEqualTo(0));
            Assert.True(((decimal) 1).NotEqualTo(0));
        }

        [Fact]
        public void Should_Be_False_Given_A_Value_Equal_To_1() 
        {
            Assert.False(((sbyte) 1).NotEqualTo(1));
            Assert.False(((byte) 1).NotEqualTo(1));
            Assert.False(((short) 1).NotEqualTo(1));
            Assert.False(((ushort) 1).NotEqualTo(1));
            Assert.False(((int) 1).NotEqualTo(1));
            Assert.False(((uint) 1).NotEqualTo(1));
            Assert.False(((long) 1).NotEqualTo(1));
            Assert.False(((ulong) 1).NotEqualTo(1));
            Assert.False(((float) 1).NotEqualTo(1));
            Assert.False(((double) 1).NotEqualTo(1));
            Assert.False(((decimal) 1).NotEqualTo(1));
        }
    }
}
