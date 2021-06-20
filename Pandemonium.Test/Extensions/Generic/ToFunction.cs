using Xunit;
using Pandemonium;
using System.Collections;
using System.Linq;

namespace Pandemonium.Test.Extensions.T
{
    public class ToFunctionTest
    {
        [Fact]
        public void Should_Be_A_Function() 
        {
            int number = 1;

            Assert.Equal("System.Func`1[System.Int32]", number.ToFunction().GetType().ToString());
        }
    }
}
