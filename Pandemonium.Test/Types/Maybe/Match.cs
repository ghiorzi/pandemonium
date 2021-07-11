using System;
using Xunit;
using Pandemonium.Types;

namespace Pandemonium.Test.Types.MaybeTest
{
    public class MatchTest
    {
        [Fact]
        public void Should_Run_Value_Function_Given_A_Value() 
        {
            Maybe<string> maybe = "value";

            maybe
                .Match(
                    value: (_) => Assert.Equal("value", _),
                    empty: () => throw new Exception("It should not run this block")
                );
        }

        [Fact]
        public void Should_Run_Value_Action_Given_A_Value() 
        {
            Maybe<string> maybe = "value";

            maybe
                .Match(
                    value: (_) => Assert.True(true), // pass
                    empty: () => Assert.True(false) // fail
                );
        }

        [Fact]
        public void Should_Run_Empty_Function_Given_Null() 
        {
            Maybe<string> maybe = null;

            maybe
                .Match(
                    value: (_) => throw new Exception("It should not run this block"),
                    empty: () => Assert.True(true)
                );
        }

        [Fact]
        public void Should_Run_Empty_Action_Given_Null() 
        {
            Maybe<string> maybe = null;

            maybe
                .Match(
                    value: (_) => Assert.True(false), // fail
                    empty: () => Assert.False(false) // pass
                );
        }
    }
}
