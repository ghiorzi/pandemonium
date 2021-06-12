using System;
using Xunit;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Strings
{
    public class AnyTest
    {
        [Fact]
        public void Should_Have_Value()
        {
            bool result = "sample".Any();

            Assert.True(result);
        }

        [Fact]
        public void Should_Have_Sample_In_Values()
        {
            bool result = "sample".Any("s", "a", "m", "sample");

            Assert.True(result);
        }

        [Fact]
        public void Should_Have_Sample_In_Values_With_String_Comparation()
        {
            bool result = "sample".Any(StringComparison.OrdinalIgnoreCase, "s", "a", "m", "sample");

            Assert.True(result);
        }

        [Fact]
        public void Should_Not_Have_Sample_In_Values()
        {
            bool result = "sample".Any("s", "a", "m", "samplesss");

            Assert.False(result);
        }

        [Fact]
        public void Should_Not_Have_Sample_In_Values_With_String_Comparation()
        {
            bool result = "sample".Any(StringComparison.OrdinalIgnoreCase, "s", "a", "m");

            Assert.False(result);
        }
    }
}
