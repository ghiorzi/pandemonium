using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.MaybeTest
{
    public class SelectTest
    {
        
        [Fact]
        public void Should_Select_Given_Valid_Input_Without_Selector() 
        {
            Maybe<int> input = 1;

            Failable<int> value = input.Select();
                    
            value.Match(
                success: (value) => Assert.Equal(1, value),
                failure: (error) => throw new Exception("Test has failed. It should run the select function")
            );
        }

        [Fact]
        public void Should_Select_Given_Valid_Input() 
        {
            Maybe<int> input = 1;

            Failable<string> value = 
                input
                    .Select((value) => "It has value");
                    
            value.Match(
                success: (value) => Assert.Equal("It has value", value),
                failure: (error) => throw new Exception("Test has failed. It should run the select function")
            );
        }

        [Fact]
        public void Should_Not_Select_Given_Invalid_Input() 
        {
            Maybe<int> input = default;

            Failable<string> value = 
                input
                    .Select((value) => "It has value");
                    
            value.Match(
                success: (value) => throw new Exception("Test has failed. It should not run the select function"),
                failure: (error) => Assert.Equal("Select has failed to result a value", error.Message)
            );
        }

        [Fact]
        public void Should_Select_Given_Valid_Query_Expression() 
        {
            Maybe<int> input = 2;

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
            Maybe<int> input = default;

            var value =
                from i in input
                select i * 2;
            
            value.Match(
                success: (_) => throw new Exception("Test has failed. It should not select number"),
                failure: (error) =>  Assert.Equal("Select has failed to result a value", error.Message)
            );
        }
    }
}
