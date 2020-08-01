using Xunit;
using System;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Number
{
    public class MillisecondsTest
    {
        [Fact]
        public void Should_Be_True_Given_1_Millisecond() 
        {
            Assert.True(((sbyte) 1).Milliseconds() == TimeSpan.FromMilliseconds(1));
            Assert.True(((short) 1).Milliseconds() == TimeSpan.FromMilliseconds(1));
            Assert.True(((int) 1).Milliseconds() == TimeSpan.FromMilliseconds(1));
            Assert.True(((long) 1).Milliseconds() == TimeSpan.FromMilliseconds(1));
            Assert.True(((float) 1.0).Milliseconds() == TimeSpan.FromMilliseconds(1));
            Assert.True(((double) 1.0).Milliseconds() == TimeSpan.FromMilliseconds(1));
        }

        [Fact]
        public void Should_Be_False_Given_2_Milliseconds() 
        {
            Assert.False(((sbyte) 2).Milliseconds() == TimeSpan.FromMilliseconds(1));
            Assert.False(((short) 2).Milliseconds() == TimeSpan.FromMilliseconds(1));
            Assert.False(((int) 2).Milliseconds() == TimeSpan.FromMilliseconds(1));
            Assert.False(((long) 2).Milliseconds() == TimeSpan.FromMilliseconds(1));
            Assert.False(((float) 2.0).Milliseconds() == TimeSpan.FromMilliseconds(1));
            Assert.False(((double) 2.0).Milliseconds() == TimeSpan.FromMilliseconds(1));
        }
    }
}
