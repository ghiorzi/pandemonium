using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.FlowTest
{
    public class OfTest
    {
        [Fact]
        public void Should_Create_Success() 
        {
            var flow = Flow.Of<bool, Exception>(true);
                    
            Assert.True(flow.Succeeded);
        }

        [Fact]
        public void Should_Create_Failure() 
        {
            var flow = Flow.Of<bool, Exception>(new Exception());
                    
            Assert.True(flow.Failed);
        }
    }
}
