using Xunit;
using System;
using Pandemonium.Types;

using static Pandemonium.Functions;

namespace Pandemonium.Test.Types.FailableTest
{
    public class ComposeTest
    {
        [Fact]
        public void Should_Compose_Functions()
        {
            Failable<int> input = 10;

            var function = 
                input
                    .Compose(
                        Where<int>(x => x % 2 == 0),
                        Where<int>(x => x >= 10)
                    );

            Assert.True(input.Succeeded);
        }

        [Fact]
        public void Should_Not_Run_Composed_Functions_Given_Lazy_Behaviour()
        {
            Failable<int> input = 10;

            var function = 
                input
                    .Compose(
                        Where<int>(x => throw new NotImplementedException()),
                        Where<int>(x => throw new NotImplementedException())
                    );

            // Since we did not call function, Where will not be called either
            Assert.True(true);
        }
    }
}
