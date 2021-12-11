using Xunit;
using Pandemonium;
using System.Collections.Generic;

namespace Pandemonium.Test.Functions.IDictionary
{
    public class UpsertTest
    {
        [Fact]
        public void Should_Insert_Given_A_Non_Existing_Key() 
        {
            var dictionary = new Dictionary<int, string>()
            {
                [0] = "0",
            };

            dictionary.Upsert(1, "1");

            bool result = dictionary.ContainsKey(1);

            Assert.True(result);
        }

        [Fact]
        public void Should_Update_Given_An_Existing_Key()
        {
            var dictionary = new Dictionary<int, string>()
            {
                [0] = "0",
            };

            dictionary.Upsert(0, "Zero");

            string result = dictionary[0];

            Assert.Equal("Zero", result);
        }
    }
}
