using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.FlowTest
{
    public class TapTest
    {
        [Fact]
        public void Should_Run_Tap() 
        {
            Flow<int, Exception> input = 10;

            Flow<int, Exception> flowAction = 
                input
                    .Ensure(x => x < 20, new Exception("Value must be less than 20"))
                    .Tap(() => Assert.True(true));

            Flow<int, Exception> flowActionT = 
                input
                    .Ensure(x => x < 20, new Exception("Value must be less than 20"))
                    .Tap((x) => Assert.True(x == 10));
        }

        [Fact]
        public void Should_Not_Run_Tap() 
        {
            Flow<int, Exception> input = 21;

            Flow<int, Exception> flowAction = 
                input
                    .Ensure(x => x < 20, new Exception("Value must be less than 20"))
                    .Tap(() => throw new Exception("Test has failed. It should not run this function"));

            Flow<int, Exception> flowActionT = 
                input
                    .Ensure(x => x < 20, new Exception("Value must be less than 20"))
                    .Tap(() => throw new Exception("Test has failed. It should not run this function"));
        }
    }
}
