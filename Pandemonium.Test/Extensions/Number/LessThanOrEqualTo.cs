using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Number
{
    public class LessThanOrEqualToTest
    {
        [Fact]
        public void Should_Be_True_Given_A_Value_Less_Than_1_Or_Equal_To_1() 
        {
            Assert.True(((sbyte) 0).LessThanOrEqualTo(1));
            Assert.True(((byte) 0).LessThanOrEqualTo(1));
            Assert.True(((short) 0).LessThanOrEqualTo(1));
            Assert.True(((ushort) 0).LessThanOrEqualTo(1));
            Assert.True(((int) 0).LessThanOrEqualTo(1));
            Assert.True(((uint) 0).LessThanOrEqualTo(1));
            Assert.True(((long) 1).LessThanOrEqualTo(1));
            Assert.True(((ulong) 1).LessThanOrEqualTo(1));
            Assert.True(((float) 1).LessThanOrEqualTo(1));
            Assert.True(((double) 1).LessThanOrEqualTo(1));
            Assert.True(((decimal) 1).LessThanOrEqualTo(1));
        }

        [Fact]
        public void Should_Be_False_Given_A_Value_Greater_Than_1() 
        {
            Assert.False(((sbyte) 2).LessThanOrEqualTo(1));
            Assert.False(((byte) 2).LessThanOrEqualTo(1));
            Assert.False(((short) 2).LessThanOrEqualTo(1));
            Assert.False(((ushort) 2).LessThanOrEqualTo(1));
            Assert.False(((int) 2).LessThanOrEqualTo(1));
            Assert.False(((uint) 2).LessThanOrEqualTo(1));
            Assert.False(((long) 2).LessThanOrEqualTo(1));
            Assert.False(((ulong) 2).LessThanOrEqualTo(1));
            Assert.False(((float) 2).LessThanOrEqualTo(1));
            Assert.False(((double) 2).LessThanOrEqualTo(1));
            Assert.False(((decimal) 2).LessThanOrEqualTo(1));
        }
    }
}
