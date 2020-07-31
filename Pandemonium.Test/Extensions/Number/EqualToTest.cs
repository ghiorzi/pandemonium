using Xunit;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Number
{
    public class EqualToTest
    {
        [Fact]
        public void Should_Be_True_Given_A_Value_Equal_To_0() 
        {
            Assert.True(((sbyte) 0).EqualTo(0));
            Assert.True(((byte) 0).EqualTo(0));
            Assert.True(((short) 0).EqualTo(0));
            Assert.True(((ushort) 0).EqualTo(0));
            Assert.True(((int) 0).EqualTo(0));
            Assert.True(((uint) 0).EqualTo(0));
            Assert.True(((long) 0).EqualTo(0));
            Assert.True(((ulong) 0).EqualTo(0));
            Assert.True(((float) 0).EqualTo(0));
            Assert.True(((double) 0).EqualTo(0));
            Assert.True(((decimal) 0).EqualTo(0));
        }

        [Fact]
        public void Should_Be_False_Given_A_Value_Not_Equal_To_1() 
        {
            Assert.False(((sbyte) 0).EqualTo(1));
            Assert.False(((byte) 0).EqualTo(1));
            Assert.False(((short) 0).EqualTo(1));
            Assert.False(((ushort) 0).EqualTo(1));
            Assert.False(((int) 0).EqualTo(1));
            Assert.False(((uint) 0).EqualTo(1));
            Assert.False(((long) 0).EqualTo(1));
            Assert.False(((ulong) 0).EqualTo(1));
            Assert.False(((float) 0).EqualTo(1));
            Assert.False(((double) 0).EqualTo(1));
            Assert.False(((decimal) 0).EqualTo(1));
        }
    }
}
