using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.NothingTest
{
    public class ThenTest
    {
        [Fact]
        public void Should_Run_Success_Given_A_Value() 
        {
            var nothing = Nothing.Of();

            var failable =
                nothing
                    .Do(() => Failable.From("success"))
                    .Match(
                        success: (value) => Assert.True(true), // pass
                        failure: (error) => throw error // fail
                    );
        }

        [Fact]
        public void Should_Run_Failure_Given_Failure_Value() 
        {
            var nothing = Nothing.Of();

            var failable =
                nothing
                    .Do(() => Failable.FromException<string>(new Exception("It could not create a failable")))
                    .Match(
                        success: (value) => throw new Exception("Test has failed. It should run failure"), // fail 
                        failure: (error) => Assert.Equal("It could not create a failable", error.Message) // pass
                    );
        }
    }
}
