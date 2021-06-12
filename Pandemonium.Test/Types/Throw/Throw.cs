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

        [Fact]
        public void Should_Raise_Exception_Given_Null_As_A_Predicate()
        {
            Assert.Throws<System.ArgumentException>(() => Throw<int, NumberIsGreaterThanEleven>.When(null));
        }

        private class NumberIsGreaterThanEleven : Exception
        {
            public NumberIsGreaterThanEleven() : base("Number cannot be greater than 11") { }
        }
    }

}
