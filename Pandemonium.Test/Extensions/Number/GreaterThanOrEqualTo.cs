using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Number
{
    public class GreaterThanOrEqualToTest
    {
        [Fact]
        public void Should_Be_True_Given_A_Value_Greater_Than_1_Or_Equal_To_1() 
        {
            Assert.True(((sbyte) 1).GreaterThanOrEqualTo(1));
            Assert.True(((byte) 3).GreaterThanOrEqualTo(2));
            Assert.True(((short) 3).GreaterThanOrEqualTo(2));
            Assert.True(((ushort) 3).GreaterThanOrEqualTo(2));
            Assert.True(((int) 3).GreaterThanOrEqualTo(2));
            Assert.True(((uint) 3).GreaterThanOrEqualTo(2));
            Assert.True(((long) 3).GreaterThanOrEqualTo(2));
            Assert.True(((ulong) 3).GreaterThanOrEqualTo(2));
            Assert.True(((float) 3).GreaterThanOrEqualTo(2));
            Assert.True(((double) 3).GreaterThanOrEqualTo(2));
            Assert.True(((decimal) 3).GreaterThanOrEqualTo(2));
        }

        [Fact]
        public void Should_Be_False_Given_A_Value_Less_Than_1() 
        {
            Assert.False(((sbyte) 0).GreaterThanOrEqualTo(1));
            Assert.False(((byte) 0).GreaterThanOrEqualTo(1));
            Assert.False(((short) 0).GreaterThanOrEqualTo(1));
            Assert.False(((ushort) 0).GreaterThanOrEqualTo(1));
            Assert.False(((int) 0).GreaterThanOrEqualTo(1));
            Assert.False(((uint) 0).GreaterThanOrEqualTo(1));
            Assert.False(((long) 0).GreaterThanOrEqualTo(1));
            Assert.False(((ulong) 0).GreaterThanOrEqualTo(1));
            Assert.False(((float) 0).GreaterThanOrEqualTo(1));
            Assert.False(((double) 0).GreaterThanOrEqualTo(1));
            Assert.False(((decimal) 0).GreaterThanOrEqualTo(1));
        }
    }
}
