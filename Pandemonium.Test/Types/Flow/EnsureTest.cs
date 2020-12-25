using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.FlowTest
{
    public class EnsureTest
    {
        [Fact]
        public void Should_Run_All_Functions() 
        {
            Flow<bool, Exception> input = true;

            Flow<bool, Exception> flow = 
                input
                    .Then<bool>((value) => Flow.Of<bool, Exception>(value))
                    .Ensure(x => x == true, new Exception("Value must be true"))
                    .Then<bool>((value) => Flow.Of<bool, Exception>(value));
                    
            flow.Match(
                onSuccess: (_) =>  Assert.True(true),
                onFailure: (_) => throw new Exception("Test has failed")
            );
        }

        [Fact]
        public void Should_Not_Keep_The_Flow_Function_Given_Fail_Previous_Step() 
        {
            Flow<bool, Exception> input = new Exception("Start with exception");

            Flow<bool, Exception> flow = 
                input
                    .Ensure(x => x == true, new Exception("Value must be true"))
                    .Then<bool>((value) => Flow.Of<bool, Exception>((true)));
                    
            flow.Match(
                onSuccess: (_) =>  throw new Exception("Test has failed. It should not run the last function"),
                onFailure: (error) => Assert.Equal("Start with exception", error.Message)
            );
        }

        [Fact]
        public void Should_Not_Keep_The_Flow_Function_Given_Fail_Predicate() 
        {
            Flow<bool, Exception> input = false;

            Flow<bool, Exception> flow = 
                input
                    .Ensure(x => x == true, new Exception("Value must be true"))
                    .Then<bool>((value) => Flow.Of<bool, Exception>((true)));
                    
            flow.Match(
                onSuccess: (_) =>  throw new Exception("Test has failed. It should not run the last function"),
                onFailure: (error) => Assert.Equal("Value must be true", error.Message)
            );
        }
    }
}
