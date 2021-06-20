using Xunit;
using Pandemonium;
using System;

namespace Pandemonium.Test.Extensions.T
{
    public class NotTest
    {
        [Fact]
        public void Should_Flip_Function()
        {
            Func<int, bool> IsEven = x => x % 2 == 0;

            Func<int, bool> IsOdd = IsEven.Not();
            
            Assert.True(IsOdd(3));
        }
    }
}
