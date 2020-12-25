using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.MaybeTest
{
    public class ThenTest
    {
        [Fact]
        public void Should_Run_OnSuccess_Given_A_Value() 
        {
            Maybe<string> maybe = "value";

            var flow =
                maybe
                    .Then((value) => Flow.Of<string, Exception>(value), new Exception("Maybe must have a value"))
                    .Match(
                        onSuccess: (value) => Assert.True(true), // pass
                        onFailure: (error) => throw error // fail
                    );
        }

        [Fact]
        public void Should_Run_OnFailure_Given_Null() 
        {
            Maybe<string> maybe = null;

            var flow =
                maybe
                    .Then((value) => Flow.Of<string, Exception>(value), new Exception("Maybe must have a value"))
                    .Match(
                        onSuccess: (value) => throw new Exception("Test has failed. It should run onFailure"), // fail 
                        onFailure: (error) => Assert.Equal("Maybe must have a value", error.Message) // pass
                    );
        }
    }
}
