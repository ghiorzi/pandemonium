using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.FlowTest
{
    public class TryTest
    {
        [Fact]
        public void Should_Catch_Exception() 
        {
            var flow = 
                Flow.Try<int, Exception>(() => throw new Exception("Function was not implemented"));
            
            flow.OnFailure((error) => Assert.Equal("Function was not implemented", error.Message));
        }

        [Fact]
        public void Should_Catch_Exception_With_Handler() 
        {
            var flow = 
                Flow.Try<int, string>
                (
                    () => throw new Exception("Function was not implemented"),
                    (exception) => exception.Message
                );
            
            flow.OnFailure((error) => Assert.Equal("Function was not implemented", error));
        }
    }
}
