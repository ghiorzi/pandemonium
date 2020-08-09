using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Object
{
    public class NullTest
    {
        [Fact]
        public void Should_Be_True_Given_A_Null_Value() 
        {
            object value = null;

            Assert.True(value.Null());
        }

        [Fact]
        public void Should_Be_False_Given_A_Non_Null_Value() 
            => Assert.False(1.Null());
    }
}
