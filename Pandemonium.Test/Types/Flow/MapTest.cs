using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.FlowTest
{
    public class MapTest
    {
        [Fact]
        public void Should_Map_Given_Valid_Flow() 
        {
            Flow<bool, Exception> input = true;

            Flow<string, Exception> flow = 
                input
                    .Ensure(x => x == true, new Exception("Value must be true"))
                    .Map<string>((value) => "Value is true");
                    
            flow.Match(
                onSuccess: (value) => Assert.Equal("Value is true", value),
                onFailure: (error) => throw new Exception("Test has failed. It should run the map function")
            );
        }

        [Fact]
        public void Should_Not_Map_Given_Invalid_Flow() 
        {
            Flow<bool, Exception> input = false;

            Flow<string, Exception> flow = 
                input
                    .Ensure(x => x == true, new Exception("Value must be true"))
                    .Map<string>((value) => "Value is true");
                    
            flow.Match(
                onSuccess: (value) => throw new Exception("Test has failed. It should not run the map function"),
                onFailure: (error) => Assert.Equal("Value must be true", error.Message)
            );
        }
    }
}
