using Xunit;
using System;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Strings
{
    public class NoneTest
    {
        [Fact]
        public void Should_Have_Sample_In_Values()
            => Assert.False("sample".None("s", "a", "m", "sample"));
        
        [Fact]
        public void Should_Not_Have_Sample_In_Values()
        {
            Assert.True("".None());      
            Assert.True("sample".None("s", "a", "m", "sampless"));
            Assert.True("sample".None(StringComparison.OrdinalIgnoreCase, "s", "a", "m", "sampless"));
        }
    }
}
