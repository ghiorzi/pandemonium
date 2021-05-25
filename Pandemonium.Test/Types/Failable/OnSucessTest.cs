using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.FailableTest
{
    public class OnSuccessTest
    {
        [Fact]
        public void Should_Run_Action_Given_Success() 
        {
            Failable<bool> flow = true;
                    
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
            Failable<bool> flow = new Exception();
                    
            // Action
            flow
                .OnSuccess(() => throw new Exception("Test has failed. It should not run this function"));
            
            // Action<T>
            flow
                .OnSuccess((_) => throw new Exception("Test has failed. It should not run this function"));
        }
    }
}
