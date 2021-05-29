using Xunit;
using Pandemonium;
using System;

namespace Pandemonium.Test.Extensions.Boolean
{
    public class ThenTest
    {
        [Fact]
        public void Should_Run_The_Action_Given_True_Value()
        {
            bool result = false;

            void action() => result = true;

            true.Then(action);

            Assert.True(result);
        }

        [Fact]
        public void Should_Run_The_Function_Given_True_Value()
        {
            static bool function() => true;

            bool result = true.Then(function);

            Assert.True(result);
        }

        [Fact]
        public void Should_Not_Run_The_Action_Given_False_Value()
        {
            bool result = false;

            void action() => result = true;

            false.Then(action);

            Assert.False(result);
        }

        [Fact]
        public void Should_Not_Run_The_Function_Given_False_Value()
        {
            static bool function() => true;

            bool result = false.Then(function);

            Assert.False(result);
        }
    }
}
