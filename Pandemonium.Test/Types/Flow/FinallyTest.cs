using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.FlowTest
{
    public class FinallyTest
    {
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Should_Run_Finally(bool value) 
        {
            Flow<bool, Exception> input = value;

            bool flow = 
                input
                    .Ensure(x => x == true, new Exception("Value must be true"))
                    .Finally<bool>((x) => true);
                    
            Assert.True(flow);
        }
    }
}
