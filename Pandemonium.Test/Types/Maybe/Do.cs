using Xunit;
using Pandemonium.Types;
using System;

using static Pandemonium.Functions;

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
                    .ToFailable()
                    .Pipe(
                        Do<string>((value) => Failable.From(value))
                    )
                    .Match(
                        success: (value) => Assert.True(true), // pass
                        failure: (_) => throw new Exception("It should not run this block") // fail
                    );
        }

        [Fact]
        public void Should_Run_Success_Given_A_Value_With_Action_Without_Argument() 
        {
            Maybe<string> maybe = "value";

            _ =
                maybe
                    .ToFailable()
                    .Pipe(
                        Do<string>(() => {})
                    )
                    .Match(
                        success: (value) => Assert.True(true), // pass
                        failure: (_) => throw new Exception("It should not run this block") // fail
                    );
        }

        [Fact]
        public void Should_Run_Empty_Given_Null()
        {
            Maybe<string> maybe = null;

            _ =
                maybe
                    .ToFailable()
                    .Pipe(
                        Do<string>((value) => {})
                    )
                    .Match(
                        success: (value) => throw new Exception("Test has failed. It should run failure"), // fail 
                        failure: (_) => Assert.True(true) // pass
                    );
        }

        [Fact]
        public void Should_Run_Empty_Given_Null_With_Aciton_Wihout_Argument() 
        {
            Maybe<string> maybe = null;

            _ =
                maybe
                    .ToFailable()
                    .Pipe(
                        Do<string>(() => {})
                    )
                    .Match(
                        success: (value) => throw new Exception("Test has failed. It should run failure"), // fail 
                        failure: (_) => Assert.True(true) // pass
                    );
        }
    }
}
