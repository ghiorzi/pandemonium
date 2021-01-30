using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.FlowTest
{
    public class MatchTest
    {
        [Fact]
        public void Should_Match_Success() 
        {
            Flow<bool, Exception> flow = true;
                    
            flow.Match(
                onSuccess: (_) =>  Assert.True(true),
                onFailure: (_) => throw new Exception("Test has failed")
            );
        }

        [Fact]
        public void Should_Match_Failure() 
        {
            Flow<bool, Exception> flow = new Exception();
                    
            flow.Match(
                onSuccess: (_) => throw new Exception("Test has failed"),
                onFailure: (_) => Assert.True(true)
            );
        }
    }
}
