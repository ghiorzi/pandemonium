using Xunit;
using Pandemonium;
using System;

namespace Pandemonium.Test.Extensions.Boolean
{
    public class ContradictionTest
    {
        [Fact]
        public void Should_Be_A_Contradiction()
            => Assert.True(false.Contradiction());
        

        [Fact]
        public void Should_Be_A_Tautology()
            => Assert.False(true.Contradiction());
    }
}
