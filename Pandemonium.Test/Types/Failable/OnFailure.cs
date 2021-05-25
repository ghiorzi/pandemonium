using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.FailableTest
{
    public class OnFailureTest
    {
        [Fact]
        public void Should_Run_Action_Given_Failure() 
        {
            Failable<bool> value = new Exception("Failure action");
                    
            // Action
            value
                .OnFailure(() => Assert.True(value.Failed));
            
            // Action<T>
            value
                .OnFailure((error) => Assert.Equal("Failure action", error.Message));
        }

        [Fact]
        public void Should_Not_Run_Action_Given_Success() 
        {
            Failable<bool> value = true;
                    
            // Action
            value
                .OnFailure(() => throw new Exception("Test has failed. It should not run this function"));
            
            // Action<T>
            value
                .OnFailure((_) => throw new Exception("Test has failed. It should not run this function"));
        }
    }
}
