using Xunit;
using Pandemonium;
using System;

namespace Pandemonium.Test.Functions.Boolean
{
    public class DoTest
    {
        [Fact]
        public void Should_Run_The_Action_Given_True_Value()
        {
            bool result = false;

            void action() => result = true;

            true.Do(action);

            Assert.True(result);
        }

        [Fact]
        public void Should_Run_The_Function_Given_True_Value()
        {
            static bool function() => true;

            true.Do(function).Match(value: _ => Assert.True(_), empty: () => {});
        }

        [Fact]
        public void Should_Not_Run_The_Action_Given_False_Value()
        {
            bool result = false;

            void action() => result = true;

            false.Do(action);

            Assert.False(result);
        }

        [Fact]
        public void Should_Not_Run_The_Function_Given_False_Value()
        {
            static bool function() => true;

            false
                .Do(function)
                .Match(value: _ => throw new Exception("It should not run this block"), empty: () => Assert.True(true));
        }
    }
}
