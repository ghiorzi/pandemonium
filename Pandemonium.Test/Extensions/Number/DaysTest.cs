using Xunit;
using System;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Number
{
    public class DaysTest
    {
        [Fact]
        public void Should_Be_True_Given_1_Day() 
        {
            Assert.True(((sbyte) 1).Days() == TimeSpan.FromDays(1));
            Assert.True(((short) 1).Days() == TimeSpan.FromDays(1));
            Assert.True(((int) 1).Days() == TimeSpan.FromDays(1));
            Assert.True(((long) 1).Days() == TimeSpan.FromDays(1));
            Assert.True(((float) 1.0).Days() == TimeSpan.FromDays(1));
            Assert.True(((double) 1.0).Days() == TimeSpan.FromDays(1));
        }

        [Fact]
        public void Should_Be_False_Given_2_Days() 
        {
            Assert.False(((sbyte) 2).Days() == TimeSpan.FromDays(1));
            Assert.False(((short) 2).Days() == TimeSpan.FromDays(1));
            Assert.False(((int) 2).Days() == TimeSpan.FromDays(1));
            Assert.False(((long) 2).Days() == TimeSpan.FromDays(1));
            Assert.False(((float) 2.0).Days() == TimeSpan.FromDays(1));
            Assert.False(((double) 2.0).Days() == TimeSpan.FromDays(1));
        }
    }
}
