using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.MaybeTest
{
    public class DoTest
    {
        [Fact]
        public void Should_Run_Success_Given_A_Value()
        {
            Maybe<string> maybe = "value";

            _ =
                maybe
                    .Do((value) => Failable.From(value))
                    .Match(
                        success: (value) => Assert.True(true), // pass
                        failure: (error) => throw error // fail
                    );
        }

        [Fact]
        public void Should_Run_Success_Given_A_Value_With_Error_Provided() 
        {
            Maybe<string> maybe = "value";

            _ =
                maybe
                    .Do((value) => Failable.From(value), new Exception("Maybe must have a value"))
                    .Match(
                        success: (value) => Assert.True(true), // pass
                        failure: (error) => throw error // fail
                    );
        }

        [Fact]
        public void Should_Run_Failure_Given_Null()
        {
            Maybe<string> maybe = null;

            _ =
                maybe
                    .Do((value) => Failable.From(value))
                    .Match(
                        success: (value) => throw new Exception("Test has failed. It should run failure"), // fail 
                        failure: (error) => Assert.Equal("Do has failed to result a value", error.Message) // pass
                    );
        }

        [Fact]
        public void Should_Run_Failure_Given_Null_With_Error_Provided() 
        {
            Maybe<string> maybe = null;

            _ =
                maybe
                    .Do((value) => Failable.From(value), new Exception("Maybe must have a value"))
                    .Match(
                        success: (value) => throw new Exception("Test has failed. It should run failure"), // fail 
                        failure: (error) => Assert.Equal("Maybe must have a value", error.Message) // pass
                    );
        }
    }
}
