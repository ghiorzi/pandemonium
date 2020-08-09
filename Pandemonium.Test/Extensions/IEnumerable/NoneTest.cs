using Xunit;
using Pandemonium;
using System.Collections.Generic;
using System.Linq;

namespace Pandemonium.Test.Extensions.IEnumerables
{
    public class NoneTest
    {
        [Fact]
        public void Should_Not_Match_Given_Predicate() 
        {
            IEnumerable<int> values = Enumerable.Range(1, 10);

            bool result = values.None(number => number > 20);

            Assert.True(result);
        }

        [Fact]
        public void Should_Match_Given_Predicate() 
        {
            IEnumerable<int> values = Enumerable.Range(1, 10);

            bool result = values.None(number => number > 9);

            Assert.False(result);
        }
    }
}
