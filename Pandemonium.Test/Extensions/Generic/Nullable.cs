using Xunit;
using System;
using Pandemonium;

namespace Pandemonium.Test.Functions.T
{
    public class NullableTest
    {
        [Fact]
        public void Should_Be_True_Given_A_Nullable_Value() 
        {
            object value = "anything";

            Assert.True(value.Nullable());
        }

        [Fact]
        public void Should_Be_False_Given_A_Non_Nullable_Value() 
            => Assert.False(DateTime.Now.Nullable());
    }
}
