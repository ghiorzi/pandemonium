using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.MaybeTest
{
    public class ToStringTest
    {
        [Fact]
        public void Should_Get_Default_Value_Given_Empty_State()
        {
            Maybe<int> maybe = default;

            Assert.Equal("It has no value", maybe.ToString());
        }

        [Fact]
        public void Should_Get_To_String_From_Value()
        {
            Maybe<int> maybe = 10;

            Assert.Equal("10", maybe.ToString());
        }
    }
}
