using Xunit;
using Pandemonium;
using System;

namespace Pandemonium.Test.Functions.T
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
                    LessThan(5)
                );
            
            Assert.True(Run(12));
            Assert.True(Run(3));
        }

        [Fact]
        public void Should_Be_False()
        {
            Func<int, bool> IsEven = x => x % 2 == 0;
            Func<int, Func<int, bool>> GreaterThan = a => b => b > a;
            Func<int, Func<int, bool>> LessThan = a => b => b < a;
            
            Func<int, bool> Run = 
                IsEven.Or(
                    GreaterThan(30),
                    LessThan(5)
                );
            
            Assert.False(Run(25));
        }
    }
}
