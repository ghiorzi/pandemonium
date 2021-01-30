using Xunit;
using Pandemonium.Types;
using System;
using Microsoft.Extensions.DependencyInjection;
using Pandemonium.Configurations;

namespace Pandemonium.Test.Types.MaybeTest
{
    public class ThenTest
    {
        [Fact]
        public void Should_Run_OnSuccess_Given_A_Value()
        {
            var services = new ServiceCollection();

            // use custom exceptions
            services.AddPandemonium();

            Maybe<string> maybe = "value";

            var flow =
                maybe
                    .Then((value) => Flow.Of<string, Exception>(value))
                    .Match(
                        onSuccess: (value) => Assert.True(true), // pass
                        onFailure: (error) => throw error // fail
                    );
        }

        [Fact]
        public void Should_Run_OnSuccess_Given_A_Value_With_Error_Provided() 
        {
            Maybe<string> maybe = "value";

            var flow =
                maybe
                    .Then((value) => Flow.Of<string, Exception>(value), new Exception("Maybe must have a value"))
                    .Match(
                        onSuccess: (value) => Assert.True(true), // pass
                        onFailure: (error) => throw error // fail
                    );
        }

        [Fact]
        public void Should_Run_OnFailure_Given_Null()
        {
            var services = new ServiceCollection();

            // use custom exceptions
            services.AddPandemonium();

            Maybe<string> maybe = null;

            var flow =
                maybe
                    .Then((value) => Flow.Of<string, Exception>(value))
                    .Match(
                        onSuccess: (value) => throw new Exception("Test has failed. It should run onFailure"), // fail 
                        onFailure: (error) => Assert.Equal("Maybe must have a value", error.Message) // pass
                    );
        }

        [Fact]
        public void Should_Run_OnFailure_Given_Null_With_Custom_Exception()
        {
            var services = new ServiceCollection();

            var exceptions = new Exceptions(maybeException: new MaybeCustomException());

            // use custom exceptions
            services.AddPandemonium(exceptions);

            Maybe<string> maybe = null;

            var flow =
                maybe
                    .Then((value) => Flow.Of<string, Exception>(value))
                    .Match(
                        onSuccess: (value) => throw new Exception("Test has failed. It should run onFailure"), // fail 
                        onFailure: (error) => Assert.Equal("This is a custom exception for Maybe", error.Message) // pass
                    );
        }

        [Fact]
        public void Should_Run_OnFailure_Given_Null_With_Error_Provided() 
        {
            Maybe<string> maybe = null;

            var flow =
                maybe
                    .Then((value) => Flow.Of<string, Exception>(value), new Exception("Maybe must have a value"))
                    .Match(
                        onSuccess: (value) => throw new Exception("Test has failed. It should run onFailure"), // fail 
                        onFailure: (error) => Assert.Equal("Maybe must have a value", error.Message) // pass
                    );
        }
    }

    public class MaybeCustomException : Exception 
    {
        internal MaybeCustomException()
            : base("This is a custom exception for Maybe")
        {
        }
    }
}
