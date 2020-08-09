using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Object
{
    public class DefaultTest
    {
        [Fact]
        public void Should_Be_True_Given_A_Null_Value() 
        {
            object @object = null;

            Assert.True(@object.Default());
        }

        [Fact]
        public void Should_Be_False_Given_A_Non_Default_Value() => Assert.False(1.Default());
    }
}
