using Xunit;
using Pandemonium;
using System.Collections.Generic;

namespace Pandemonium.Test.Functions.IDictionary
{
    public class AnyTest
    {
        [Fact]
        public void Should_Be_True_Given_An_Existing_Key() 
        {
            var dictionary = new Dictionary<int, string>()
            {
                [0] = "0",
                [1] = "1"
            };

            bool result = dictionary.Any(0, 2, 3, 4);

            Assert.True(result);
        }

        [Fact]
        public void Should_Be_False_Given_Non_Existing_Keys()
        {
            var dictionary = new Dictionary<int, string>()
            {
                [0] = "0",
                [1] = "1"
            };

            bool result = dictionary.Any(2, 3, 4);

            Assert.False(result);
        }
    }
}
