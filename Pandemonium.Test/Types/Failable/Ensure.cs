using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.FailableTest
{
    public class EnsureTest
    {
        [Fact]
        public void Should_Run_All_Functions() 
        {
            Failable<bool> input = true;

            Failable<bool> value = 
                input
                    .Do<bool>((_) => _)
                    .Ensure(x => x == true)
                    .Do<bool>((_) => _);
                    
            value.Match(
                success: (_) =>  Assert.True(true),
                failure: (_) => throw new Exception("Test has failed")
            );
        }

        [Fact]
        public void Should_Not_Keep_The_Continuation_Given_Fail_Previous_Step() 
        {
            Failable<bool> input = new Exception("Start with exception");

            Failable<bool> value = 
                input
                    .Ensure(x => x == true, new Exception("Value must be true"))
                    .Do<bool>((_) => true);
                    
            value.Match(
                success: (_) =>  throw new Exception("Test has failed. It should not run the last function"),
                failure: (error) => Assert.Equal("Start with exception", error.Message)
            );
        }

        [Fact]
        public void Should_Not_Keep_The_Continuation_Function_Given_Fail_Predicate() 
        {
            Failable<bool> input = false;

            Failable<bool> value = 
                input
                    .Ensure(x => x == true, new Exception("Value must be true"))
                    .Do<bool>((_) => true);
                    
            value.Match(
                success: (_) =>  throw new Exception("Test has failed. It should not run the last function"),
                failure: (error) => Assert.Equal("Value must be true", error.Message)
            );
        }
    }
}
