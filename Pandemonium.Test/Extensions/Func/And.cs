using Xunit;
using Pandemonium;
using System;

namespace Pandemonium.Test.Functions.T
{
    public class AndTest
    {
        [Fact]
        public void Should_Be_True()
        {
            Func<int, bool> IsEven = x => x % 2 == 0;
            Func<int, Func<int, bool>> GreaterThan = a => b => b > a;
            Func<int, Func<int, bool>> LessThan = a => b => b < a;
            
            Func<int, bool> Run = 
                IsEven.And(
                    GreaterThan(10),
                    LessThan(20)
                );
            
            Assert.True(Run(12));
            Assert.False(Run(2));
            Assert.False(Run(22));
        }
    }
}
