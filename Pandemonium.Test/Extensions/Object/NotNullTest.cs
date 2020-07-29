using Xunit;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Object
{
    public class NotNullTest
    {
        [Fact]
        public void Should_Be_False_Given_A_Null_Value() 
        {
            object value = null;

            Assert.False(value.NotNull());
        }

        [Fact]
        public void Should_Be_True_Given_A_Non_Null_Value() => Assert.True(1.NotNull());
    }
}
