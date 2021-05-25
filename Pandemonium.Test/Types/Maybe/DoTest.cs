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
        public void Should_Run_Success_Given_A_Value()
        {
            var services = new ServiceCollection();

            // use custom exceptions
            services.AddPandemonium();

            Maybe<string> maybe = "value";

            _ =
                maybe
                    .Do((value) => Failable.From(value))
                    .Match(
                        success: (value) => Assert.True(true), // pass
                        failure: (error) => throw error // fail
                    );
        }

        [Fact]
        public void Should_Run_Success_Given_A_Value_With_Error_Provided() 
        {
            Maybe<string> maybe = "value";

            _ =
                maybe
                    .Do((value) => Failable.From<string>(value), new Exception("Maybe must have a value"))
                    .Match(
                        success: (value) => Assert.True(true), // pass
                        failure: (error) => throw error // fail
                    );
        }

        [Fact]
        public void Should_Run_Failure_Given_Null()
        {
            var services = new ServiceCollection();

            // use custom exceptions
            services.AddPandemonium();

            Maybe<string> maybe = null;

            _ =
                maybe
                    .Do((value) => Failable.From(value))
                    .Match(
                        success: (value) => throw new Exception("Test has failed. It should run failure"), // fail 
                        failure: (error) => Assert.Equal("Maybe must have a value", error.Message) // pass
                    );
        }

        [Fact]
        public void Should_Run_Failure_Given_Null_With_Custom_Exception()
        {
            var services = new ServiceCollection();

            var exceptions = new Exceptions(maybeException: new MaybeCustomException());

            // use custom exceptions
            services.AddPandemonium(exceptions);

            Maybe<string> maybe = null;

            _ =
                maybe
                    .Do((value) => Failable.From(value))
                    .Match(
                        success: (value) => throw new Exception("Test has failed. It should run failure"), // fail 
                        failure: (error) => Assert.Equal("This is a custom exception for Maybe", error.Message) // pass
                    );
        }

        [Fact]
        public void Should_Run_Failure_Given_Null_With_Error_Provided() 
        {
            Maybe<string> maybe = null;

            _ =
                maybe
                    .Do((value) => Failable.From(value), new Exception("Maybe must have a value"))
                    .Match(
                        success: (value) => throw new Exception("Test has failed. It should run failure"), // fail 
                        failure: (error) => Assert.Equal("Maybe must have a value", error.Message) // pass
                    );
        }
    }

    internal class MaybeCustomException : Exception 
    {
        internal MaybeCustomException()
            : base("This is a custom exception for Maybe")
        {
        }
    }
}
