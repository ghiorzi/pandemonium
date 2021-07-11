using Xunit;
using System;
using Pandemonium;

namespace Pandemonium.Test.Functions.Strings
{
    public class SelectTest
    {
        [Fact]
        public void Should_Select()
        {
            Assert.Equal("a", "a".Select());
            Assert.Equal(20, "10".Select(_ => Int32.Parse(_) * 2));
        }
    }
}
