using Xunit;
using Pandemonium;
using System.Collections;
using System.Linq;

namespace Pandemonium.Test.Extensions.T
{
    public class ToListTest
    {
        [Fact]
        public void Should_Be_A_List_Type() 
        {
            int number = 1;

            Assert.True(number.ToList() is IList);
        }

        [Fact]
        public void Should_Create_A_List_With_A_Single_Item() 
        {
            int number = 1;

            int first = number.ToList().First();

            Assert.Equal(first, number);
        }
    }
}
