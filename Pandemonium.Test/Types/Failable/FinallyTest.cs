using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.FailableTest
{
    public class FinallyTest
    {
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Should_Run_Finally(bool value) 
        {
            Failable<bool> input = value;

            bool _ = 
                input
                    .Ensure(x => x == true, new Exception("Value must be true"))
                    .Finally((x) => true);
                    
            Assert.True(_);
        }
    }
}
