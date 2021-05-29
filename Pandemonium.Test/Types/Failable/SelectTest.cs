using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.FailableTest
{
    public class SelectTest
    {
        [Fact]
        public void Should_Select_Given_Valid_Input() 
        {
            Failable<bool> input = true;

            Failable<string> value = 
                input
                    .Ensure(x => x == true, new Exception("Value must be true"))
                    .Select((value) => "Value is true");
                    
            value.Match(
                success: (value) => Assert.Equal("Value is true", value),
                failure: (error) => throw new Exception("Test has failed. It should run the select function")
            );
        }

        [Fact]
        public void Should_Not_Select_Given_Invalid_Input() 
        {
            Failable<bool> input = false;

            Failable<string> value = 
                input
                    .Ensure(x => x == true, new Exception("Value must be true"))
                    .Select((value) => "Value is true");
                    
            value.Match(
                success: (value) => throw new Exception("Test has failed. It should not run the select function"),
                failure: (error) => Assert.Equal("Value must be true", error.Message)
            );
        }

        [Fact]
        public void Should_Select_Given_Valid_Query_Expression() 
        {
            Failable<int> input = 2;

            var value =
                from i in input
                select i * 2;
            
            value.Match(
                success: (_) => Assert.Equal(4, _),
                failure: (error) => throw new Exception("Test has failed. It should run the select function")
            );
        }

        [Fact]
        public void Should_Select_Exception_Given_Valid_Query_Expression() 
        {
            Failable<int> input = new Exception("I'm not a number");

            var value =
                from i in input
                select i * 2;
            
            value.Match(
                success: (_) => throw new Exception("Test has failed. It should not select number"),
                failure: (error) =>  Assert.Equal("I'm not a number", error.Message)
            );
        }
    }
}
