using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.FailableTest
{
    public class MatchTest
    {
        [Fact]
        public void Should_Match_Success() 
        {
            Failable<bool> value = true;
                    
            value.Match(
                success: (_) =>  Assert.True(true),
                failure: (_) => throw new Exception("Test has failed")
            );
        }

        [Fact]
        public void Should_Match_Failure() 
        {
            Failable<bool> value = new Exception();
                    
            value.Match(
                success: (_) => throw new Exception("Test has failed"),
                failure: (_) => Assert.True(true)
            );
        }
    }
}
