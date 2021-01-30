using Xunit;
using Pandemonium;
using Microsoft.Extensions.DependencyInjection;
using Pandemonium.Configurations;
using System;

namespace Pandemonium.Test.Configurations
{
    public class AddPandemoniumTest
    {
        [Fact]
        public void Should_Use_Default_Exceptions()
        {
            var services = new ServiceCollection();

            services.AddPandemonium();

            Assert.Equal("NonEmptyString must have a value. It cannot be null or empty", Configuration.Exceptions.NonEmptyStringException.Message);
            Assert.Equal("NonNegativeNumber must have a positive value", Configuration.Exceptions.NonNegativeNumberException.Message);
        }

        [Fact]
        public void Should_Use_Custom_Exceptions()
        {
            var services = new ServiceCollection();

            var exceptions = 
                new Exceptions(
                    new NonEmptyStringCustomException(), 
                    new NonNegativeNumberCustomException()
                );

            // use custom exceptions
            services.AddPandemonium(exceptions);

            Assert.Equal("This is a custom exception for NonEmptyString", Configuration.Exceptions.NonEmptyStringException.Message);
            Assert.Equal("This is a custom exception for NonNegativeNumber", Configuration.Exceptions.NonNegativeNumberException.Message);
        }
    }

    public class NonEmptyStringCustomException : Exception 
    {
        internal NonEmptyStringCustomException()
            : base("This is a custom exception for NonEmptyString")
        {
        }
    }

    public class NonNegativeNumberCustomException : Exception 
    {
        internal NonNegativeNumberCustomException()
            : base("This is a custom exception for NonNegativeNumber")
        {
        }
    }
}
