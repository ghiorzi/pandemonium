using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.FlowTest
{
    public class OnFailureTest
    {
        [Fact]
        public void Should_Run_Action_Given_Failure() 
        {
            var flow = Flow.Of<bool, Exception>(new Exception("Failure action"));
                    
            // Action
            flow
                .OnFailure(() => Assert.True(flow.Failed));
            
            // Action<T>
            flow
                .OnFailure((error) => Assert.Equal("Failure action", error.Message));
        }

        [Fact]
        public void Should_Not_Run_Action_Given_Success() 
        {
            var flow = Flow.Of<bool, Exception>(true);
                    
            // Action
            flow
                .OnFailure(() => throw new Exception("Test has failed. It should not run this function"));
            
            // Action<T>
            flow
                .OnFailure((_) => throw new Exception("Test has failed. It should not run this function"));
        }
    }
}
