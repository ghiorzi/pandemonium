using Xunit;
using Pandemonium.Extensions;
using System;

namespace Pandemonium.Test.Extensions.Boolean
{
    public class OtherwiseTest
    {
        [Fact]
        public void Should_Run_The_Action_Given_False_Value()
        {
            bool result = false;

            Action action = () => result = true;

            false.Otherwise(action);

            Assert.True(result);
        }

        [Fact]
        public void Should_Not_Run_The_Action_Given_True_Value()
        {
            bool result = false;

            Action action = () => result = true;

            true.Otherwise(action);

            Assert.False(result);
        }
    }
}
