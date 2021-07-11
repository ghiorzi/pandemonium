using Xunit;
using Pandemonium;
using System.Collections.Generic;
using System.Linq;

namespace Pandemonium.Test.Functions.IEnumerables
{
    public class ExcludeTest
    {
        [Fact]
        public void Should_Select_Numbers_Less_Than_Five() 
        {
            IEnumerable<int> values = Enumerable.Range(1, 10);

            var result = values.Exclude(x => x >= 5);

            Assert.Equal(4, result.Last());
        }
    }
}
