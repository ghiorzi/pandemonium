using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.ThrowTest
{
    public class ThrowTest
    {
        [Fact]
        public void Should_Throw_Exception()
        {
            var action =
                Throw<int, NumberIsGreaterThanEleven>
                    .When(x => x > 11)
                    .Throw();

           Assert.Throws<NumberIsGreaterThanEleven>(() => action(12));
        }

        [Fact]
        public void Should_Not_Catch_Exception()
        {
            Throw<int, NumberIsGreaterThanEleven>
                .When(x => x > 11)
                .Throw()
                (10);
        }

        private class NumberIsGreaterThanEleven : Exception
        {
            public NumberIsGreaterThanEleven() : base("Number cannot be greater than 11") { }
        }
    }

}
