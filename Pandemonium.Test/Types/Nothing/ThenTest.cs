using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.NothingTest
{
    public class ThenTest
    {
        [Fact]
        public void Should_Run_OnSuccess_Given_A_Value() 
        {
            var nothing = Nothing.Of();

            var flow =
                nothing
                    .Then(() => Flow.Of<string, Exception>("success"))
                    .Match(
                        onSuccess: (value) => Assert.True(true), // pass
                        onFailure: (error) => throw error // fail
                    );
        }

        [Fact]
        public void Should_Run_OnFailure_Given_Failure_Value() 
        {
            var nothing = Nothing.Of();

            var flow =
                nothing
                    .Then(() => Flow.Of<string, Exception>(new Exception("It could not create a flow")))
                    .Match(
                        onSuccess: (value) => throw new Exception("Test has failed. It should run onFailure"), // fail 
                        onFailure: (error) => Assert.Equal("It could not create a flow", error.Message) // pass
                    );
        }
    }
}
