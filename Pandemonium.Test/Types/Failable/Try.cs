using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.FailableTest
{
    public class TryTest
    {
        [Fact]
        public void Should_Catch_Exception() 
        {
            var value = 
                Failable.Try<int>(() => throw new Exception("Function was not implemented"));
            
            value.Match(
                success: (_) => {},
                failure: (error) => Assert.Equal("Function was not implemented", error.Message)
            );
        }

        [Fact]
        public void Should_Catch_Exception_With_Handler() 
        {
            var value = 
                Failable.Try<int, string>
                (
                    () => throw new Exception("Function was not implemented"),
                    (exception) => exception.Message
                );
            
            value.Match(
                success: (_) => {},
                failure: (error) => Assert.Equal("Function was not implemented", error.Message)
            );
        }
    }
}
