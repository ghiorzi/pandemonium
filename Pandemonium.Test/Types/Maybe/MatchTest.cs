using Xunit;
using Pandemonium.Types;

namespace Pandemonium.Test.Types.MaybeTest
{
    public class MatchTest
    {
        [Fact]
        public void Should_Run_OnSome_Function_Given_A_Value() 
        {
            Maybe<string> maybe = "value";

            bool Flow =
                maybe
                    .Match<bool>(
                        onSome: (value) => true,
                        onNone: () => false
                    );
            
            Assert.True(Flow);
        }

        [Fact]
        public void Should_Run_OnSome_Action_Given_A_Value() 
        {
            Maybe<string> maybe = "value";

            maybe
                .Match(
                    onSome: (value) => Assert.True(true), // pass
                    onNone: () => Assert.True(false) // fail
                );
        }

        [Fact]
        public void Should_Run_OnNone_Function_Given_Null() 
        {
            Maybe<string> maybe = null;

            bool Flow = 
                maybe.
                    Match<bool>(
                        onSome: (value) => true,
                        onNone: () => false
                   );
            
            Assert.False(Flow);
        }

        [Fact]
        public void Should_Run_OnNone_Action_Given_Null() 
        {
            Maybe<string> maybe = null;

            maybe
                .Match(
                    onSome: (value) => Assert.True(false), // fail
                    onNone: () => Assert.False(false) // pass
                );
        }
    }
}
