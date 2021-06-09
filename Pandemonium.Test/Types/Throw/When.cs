using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.ThrowTest
{
    public class WhenTest
    {
        [Fact]
        public void Should_Catch_Exception()
        {
            var action =
                Throw<int, NumberIsGreaterThanEleven>
                    .When(x => x > 11)
                    .Catch(_ => Assert.Equal("Number cannot be greater than 11", _.Message));

            action(12);
        }

        [Fact]
        public void Should_Catch_Exception_Using_Function()
        {
            var function =
                Throw<int, NumberIsGreaterThanEleven>
                    .When(x => x > 11)
                    .Catch(_ => _.Message);

            function(12)
                .Match(
                    value: (_) => Assert.Equal("Number cannot be greater than 11", _),
                    empty: () => throw new Exception("It should not run this block")
                );
        }

        [Fact]
        public void Should_Not_Catch_Exception()
        {
            Throw<int, NumberIsGreaterThanEleven>
                .When(x => x > 11)
                .Catch(_ => throw new Exception("It should not run this block"))
                (10);
        }

        private class NumberIsGreaterThanEleven : Exception
        {
            public NumberIsGreaterThanEleven() : base("Number cannot be greater than 11") { }
        }
    }

}
