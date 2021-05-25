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

            bool value =
                maybe
                    .Match(
                        value: (_) => true,
                        empty: () => false
                    );
            
            Assert.True(value);
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

            bool value = 
                maybe.
                    Match(
                        value: (_) => true,
                        empty: () => false
                   );
            
            Assert.False(value);
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
