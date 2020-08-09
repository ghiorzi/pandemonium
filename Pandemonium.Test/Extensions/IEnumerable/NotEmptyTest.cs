using Xunit;
using Pandemonium.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Pandemonium.Test.Extensions.IEnumerables
{
    public class NotEmptyTest
    {
        [Fact]
        public void Should_Not_Be_Empty() 
        {
            IEnumerable<int> values = Enumerable.Range(1, 10);

            bool result = values.NotEmpty();

            Assert.True(result);
        }

        [Fact]
        public void Should_Be_Empty() 
        {
            IEnumerable<int> values = new List<int>();

            bool result = values.NotEmpty();

            Assert.False(result);
        }
    }
}
