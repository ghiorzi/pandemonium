using Xunit;
using System;
using Pandemonium;

namespace Pandemonium.Test.Functions.T
{
    public class NotNullableTest
    {
        [Fact]
        public void Should_Be_False_Given_A_Nullable_Type() 
        {
            object value = "anything";

            Assert.False(value.NotNullable());
        }

        [Fact]
        public void Should_Be_True_Given_A_Non_Nullable_Type() 
            => Assert.True(DateTime.Now.NotNullable());
    }
}
