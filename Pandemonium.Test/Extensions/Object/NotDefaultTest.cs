using Xunit;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Object
{
    public class NotDefaultTest
    {
        [Fact]
        public void Should_Be_False_Given_A_Null_Value() 
        {
            object @object = null;

            Assert.False(@object.NotDefault());
        }

        [Fact]
        public void Should_Be_True_Given_A_Non_Default_Value() => Assert.True(1.NotDefault());
    }
}
