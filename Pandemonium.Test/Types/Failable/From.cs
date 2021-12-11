using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.FailableTest
{
    public class FromTest
    {
        [Fact]
        public void Should_Create_Success() 
        {
            var value = Failable.From(true);
                    
            Assert.True(value.Succeeded);
        }

        [Fact]
        public void Should_Create_Failure() 
        {
            var value = Failable.From(new Exception());
                    
            Assert.True(value.Failed);
        }
    }
}
