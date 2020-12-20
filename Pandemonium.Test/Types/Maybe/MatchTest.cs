using Xunit;
using Pandemonium.Types;

namespace Pandemonium.Test.Types.Match
{
    public class MatchTest
    {
        [Fact]
        public void Should_Run_OnSome_Function_Given_A_Value() 
        {
            Maybe<string> maybe = "value";

            bool result = maybe
                               .Match<bool>(
                                    OnSome: (value) => true,
                                    OnNone: () => false
                                );
            
            Assert.True(result);
        }

        [Fact]
        public void Should_Run_OnSome_Action_Given_A_Value() 
        {
            Maybe<string> maybe = "value";

            maybe
                .Match(
                    OnSome: (value) => Assert.True(true), // pass
                    OnNone: () => Assert.True(false) // fail
                );
        }

        [Fact]
        public void Should_Run_OnNone_Function_Given_Null() 
        {
            Maybe<string> maybe = null;

            bool result = maybe
                               .Match<bool>(
                                    OnSome: (value) => true,
                                    OnNone: () => false
                                );
            
            Assert.False(result);
        }

        [Fact]
        public void Should_Run_OnNone_Action_Given_Null() 
        {
            Maybe<string> maybe = null;

            maybe
                .Match(
                    OnSome: (value) => Assert.True(false), // fail
                    OnNone: () => Assert.False(false) // pass
                );
        }
    }
}
