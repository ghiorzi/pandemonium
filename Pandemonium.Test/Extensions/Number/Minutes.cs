using Xunit;
using System;
using Pandemonium;

namespace Pandemonium.Test.Functions.Number
{
    public class MinutesTest
    {
        [Fact]
        public void Should_Be_True_Given_1_Minute() 
        {
            Assert.True(((sbyte) 1).Minutes() == TimeSpan.FromMinutes(1));
            Assert.True(((short) 1).Minutes() == TimeSpan.FromMinutes(1));
            Assert.True(((int) 1).Minutes() == TimeSpan.FromMinutes(1));
            Assert.True(((long) 1).Minutes() == TimeSpan.FromMinutes(1));
            Assert.True(((float) 1.0).Minutes() == TimeSpan.FromMinutes(1));
            Assert.True(((double) 1.0).Minutes() == TimeSpan.FromMinutes(1));
        }

        [Fact]
        public void Should_Be_False_Given_2_Minutes() 
        {
            Assert.False(((sbyte) 2).Minutes() == TimeSpan.FromMinutes(1));
            Assert.False(((short) 2).Minutes() == TimeSpan.FromMinutes(1));
            Assert.False(((int) 2).Minutes() == TimeSpan.FromMinutes(1));
            Assert.False(((long) 2).Minutes() == TimeSpan.FromMinutes(1));
            Assert.False(((float) 2.0).Minutes() == TimeSpan.FromMinutes(1));
            Assert.False(((double) 2.0).Minutes() == TimeSpan.FromMinutes(1));
        }
    }
}
