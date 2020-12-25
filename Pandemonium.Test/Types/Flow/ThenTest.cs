using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.FlowTest
{
    public class ThenTest
    {
        [Fact]
        public void Should_Run_All_Functions() 
        {
            Flow<bool, Exception> input = false;

            Flow<bool, Exception> flow = 
                input
                    .Then<bool>((value) => Flow.Of<bool, Exception>(value))
                    .Then<bool>((value) => Flow.Of<bool, Exception>(value))
                    .Then<bool>((value) => Flow.Of<bool, Exception>(value));
                    
            flow.Match(
                onSuccess: (_) =>  Assert.True(true),
                onFailure: (_) => throw new Exception("Test has failed")
            );
        }

        [Fact]
        public void Should_Not_Run_The_Last_Function() 
        {
            Flow<bool, Exception> input = false;

            Flow<bool, Exception> flow = 
                input
                    .Then<bool>((value) => Flow.Of<bool, Exception>(false))
                    .Then<bool>((value) => Flow.Of<bool, Exception>((new Exception("Then has failed")))
                    .Then<bool>((value) => Flow.Of<bool, Exception>((true))));
                    
            flow.Match(
                onSuccess: (_) =>  throw new Exception("Test has failed. It should not run the last function"),
                onFailure: (error) => Assert.Equal("Then has failed", error.Message)
            );
        }
    }
}
