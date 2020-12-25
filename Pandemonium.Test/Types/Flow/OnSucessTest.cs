using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.FlowTest
{
    public class OnSuccessTest
    {
        [Fact]
        public void Should_Run_Action_Given_Success() 
        {
            var flow = Flow.Of<bool, Exception>(true);
                    
            // Action
            flow
                .OnSuccess(() => Assert.True(flow.Succeeded));
            
            // Action<T>
            flow
                .OnSuccess((value) => Assert.True(value));
        }

        [Fact]
        public void Should_Not_Run_Action_Given_Failure() 
        {
            var flow = Flow.Of<bool, Exception>(new Exception());
                    
            // Action
            flow
                .OnSuccess(() => throw new Exception("Test has failed. It should not run this function"));
            
            // Action<T>
            flow
                .OnSuccess((_) => throw new Exception("Test has failed. It should not run this function"));
        }
    }
}
