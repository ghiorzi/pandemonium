using Xunit;
using System;
using Pandemonium;

namespace Pandemonium.Test.Functions.Number
{
    public class HoursTest
    {
        [Fact]
        public void Should_Be_True_Given_1_Hour() 
        {
            Assert.True(((sbyte) 1).Hours() == TimeSpan.FromHours(1));
            Assert.True(((short) 1).Hours() == TimeSpan.FromHours(1));
            Assert.True(((int) 1).Hours() == TimeSpan.FromHours(1));
            Assert.True(((long) 1).Hours() == TimeSpan.FromHours(1));
            Assert.True(((float) 1.0).Hours() == TimeSpan.FromHours(1));
            Assert.True(((double) 1.0).Hours() == TimeSpan.FromHours(1));
        }

        [Fact]
        public void Should_Be_False_Given_2_Hours() 
        {
            Assert.False(((sbyte) 2).Hours() == TimeSpan.FromHours(1));
            Assert.False(((short) 2).Hours() == TimeSpan.FromHours(1));
            Assert.False(((int) 2).Hours() == TimeSpan.FromHours(1));
            Assert.False(((long) 2).Hours() == TimeSpan.FromHours(1));
            Assert.False(((float) 2.0).Hours() == TimeSpan.FromHours(1));
            Assert.False(((double) 2.0).Hours() == TimeSpan.FromHours(1));
        }
    }
}
