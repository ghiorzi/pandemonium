using System;
using Xunit;
using Pandemonium.Extensions;

namespace Pandemonium.Test.Extensions.Boolean
{
    public class TernaryTest
    {
        [Fact]
        public void Should_Get_The_True_Value_Given_True_Condition() => Assert.True(true.Ternary(true, false));

        [Fact]
        public void Should_Get_The_False_Value_Given_False_Condition() => Assert.False(false.Ternary(true, false));

    }
}
