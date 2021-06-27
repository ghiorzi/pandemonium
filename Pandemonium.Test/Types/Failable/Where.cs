using Xunit;
using Pandemonium;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.FailableTest
{
    public class WhereTest
    {
        private static readonly string WHERE_EXCEPTION_MESSAGE = "Where has failed to result a value";
        private static readonly string WHERE_CUSTOM_EXCEPTION_MESSAGE = "This is a custom exception";

        [Fact]
        public void Should_Select_Square_Of_Ten_Given_Successful_Predicate() 
        {
            Failable<int> input = 10;

            Failable<int> value = 
                input
                    .Where(x => x % 2 == 0)
                    .Select((_) => _ * _);
                    
            value.Match(
                success: (_) => Assert.Equal(100, _),
                failure: (_) => throw new Exception("Test has failed")
            );
        }

        [Fact]
        public void Should_Select_Square_Of_Ten_Given_Successful_Predicate_With_Query_Expression() 
        {
            Failable<int> input = 10;

            Failable<int> value =
                from i in input
                where i % 2 == 0
                select i * i;
                    
            value.Match(
                success: (_) => Assert.Equal(100, _),
                failure: (_) => throw new Exception("Test has failed")
            );
        }

        [Fact]
        public void Should_Not_Select_Square_Of_Ten_Given_Unsuccessful_Predicate() 
        {
            Failable<int> input = 10;
         
            Failable<int> value =
                input
                    .Where(x => x % 2 == 1)
                    .Select(_ => _ * _);
                    
            value.Match(
                success: (_) => throw new Exception("Test has failed"),
                failure: (_) => Assert.Equal(WHERE_EXCEPTION_MESSAGE, _.Message)
            );
        }

        [Fact]
        public void Should_Not_Select_Square_Of_Ten_Given_Failed_State() 
        {
            Failable<int> input = default;
         
            // From value
            input
                .Where(x => x % 2 == 1)
                .Select(_ => _ * _)
                .Match(
                    success: (_) => throw new Exception("Test has failed"),
                    failure: (_) => Assert.Equal(WHERE_EXCEPTION_MESSAGE, _.Message)
                );

            // From exception
            Failable
                .From<object>(new Exception("It could not create the value"))
                .Where(x => x is not Exception)
                .Match(
                    success: (_) => throw new Exception("Test has failed"),
                    failure: (_) => Assert.Equal("It could not create the value", _.Message)
                );
        }

        [Fact]
        public void Should_Not_Select_Square_Of_Ten_Given_Unsuccessful_Predicate_With_Custom_Exception() 
        {
            Failable<int> input = 10;
         
            Failable<int> value =
                input
                    .Where(x => x % 2 == 1, new Exception(WHERE_CUSTOM_EXCEPTION_MESSAGE))
                    .Select(_ => _ * _);
                    
            value.Match(
                success: (_) => throw new Exception("Test has failed"),
                failure: (_) => Assert.Equal(WHERE_CUSTOM_EXCEPTION_MESSAGE, _.Message)
            );
        }

        [Fact]
        public void Should_Not_Select_Square_Of_Ten_Given_Unsuccessful_Predicate_With_Query_Expression() 
        {
            Failable<int> input = 10;
         
            Failable<int> value =
                from i in input
                where i % 2 == 1
                select i * i;
                    
            value.Match(
                success: (_) => throw new Exception("Test has failed"),
                failure: (_) => Assert.Equal(WHERE_EXCEPTION_MESSAGE, _.Message)
            );
        }
    }
}
