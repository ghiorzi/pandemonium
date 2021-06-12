using Xunit;
using Pandemonium.Types;

namespace Pandemonium.Test.Types.MaybeTest
{
    public class NothingTest
    {
        [Fact]
        public void Should_Get_Nothing() 
        {
            #pragma warning disable CS0183
            Assert.True(Maybe.Nothing is Nothing);
        }
    }
}
