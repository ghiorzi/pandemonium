using Xunit;
using Pandemonium;
using System;

namespace Pandemonium.Test.Extensions.Boolean
{
    public class OtherwiseTest
    {
        [Fact]
        public void Should_Run_The_Action_Given_False_Value()
        {
            bool result = false;

            void action() => result = true;

            false.Otherwise(action);

            Assert.True(result);
        }

        [Fact]
        public void Should_Run_The_Function_Given_False_Value()
        {
            Func<int> function = () => 10;

            false
                .Otherwise(function)
                .Match(
                    value: _ => Assert.Equal(10, _),
                    empty: () => throw new Exception("It should not run this block")
                );
        }

        [Fact]
        public void Should_Not_Run_The_Action_Given_True_Value()
        {
            bool result = false;

            void action() => result = true;

            true.Otherwise(action);

            Assert.False(result);
        }
            
        [Fact]
        public void Should_Not_Run_The_Function_Given_True_Value()
        {
            Func<int> function = () => 10;

            true
                .Otherwise(function)
                .Match(
                    value: _ => throw new Exception("It should not run this block"),
                    empty: () => Assert.True(true)
                );
        }
    }
}
