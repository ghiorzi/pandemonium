using Xunit;
using Pandemonium;
using System.Collections.Generic;

namespace Pandemonium.Test.Functions.IDictionary
{
    public class NoneTest
    {
        [Fact]
        public void Should_Be_True_Given_A_Non_Existing_Key() 
        {
            var dictionary = new Dictionary<int, string>()
            {
                [0] = "0",
                [1] = "1"
            };

            bool result = dictionary.None(2);

            Assert.True(result);
        }

        [Fact]
        public void Should_Be_False_Given_Existing_Keys()
        {
            var dictionary = new Dictionary<int, string>()
            {
                [0] = "0",
                [1] = "1"
            };

            bool result = dictionary.None(0, 1);

            Assert.False(result);
        }
    }
}
