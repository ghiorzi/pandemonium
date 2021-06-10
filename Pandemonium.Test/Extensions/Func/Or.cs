using Xunit;
using Pandemonium;
using System;

namespace Pandemonium.Test.Extensions.Func
{
    public class OrTest
    {
        [Fact]
        public void Should_Be_True()
        {
            Func<int, bool> IsEven = x => x % 2 == 0;
            Func<int, Func<int, bool>> GreaterThan = a => b => b > a;
            Func<int, Func<int, bool>> LessThan = a => b => b < a;
            
            Func<int, bool> Run = 
                IsEven.Or(
                    GreaterThan(10),
                    LessThan(20)
                );
            
            Assert.True(Run(12));
        }
    }
}
