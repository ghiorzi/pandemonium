using Xunit;
using Pandemonium;
using Pandemonium.Types;
using static Pandemonium.Functions;
using System;

namespace Pandemonium.Test.Types.FailableTest
{
    public class DoTest
    {
        [Fact]
        public void Should_Do()
        {
            Failable<int> input = 10;

            _ =
                input
                    .Pipe(
                        Where<int>(x => x < 20, new Exception("Value must be less than 20")),
                        Do<int>(() => Assert.True(true))
                    );

            _ =
                input
                    .Pipe(
                        Where<int>(x => x < 20, new Exception("Value must be less than 20")),
                        Do<int>((x) => Assert.True(x ==  10))
                    );
        }

        [Fact]
        public void Should_Not_Do()
        {
            Failable<int> input = 21;

            _ =
                input
                    .Pipe(
                        Where<int>(x => x < 20, new Exception("Value must be less than 20")),
                        Do<int>(() => throw new Exception("Test has failed. It should not run this function"))
                    );

            _ =
                input
                    .Pipe(
                        Where<int>(x => x < 20, new Exception("Value must be less than 20")),
                        Do<int>(() => throw new Exception("Test has failed. It should not run this function"))
                    );
        }

        [Fact]
        public void Should_Do_All_Actions()
        {
            Failable<bool> input = false;

            Failable<bool> value =
                input
                    .Pipe(
                        Do<bool>((_) => {})
                    )
                    .Select();

            value.Match(
                success: (_) => Assert.True(true),
                failure: (_) => throw new Exception("Test has failed")
            );
        }

        [Fact]
        public void Should_Not_Do_Last_Action()
        {
            Failable<bool> input = false;

            Failable<bool> value =
                input
                    .Pipe(
                        Do<bool>((_) => {}),
                        Do<bool>((_) => Assert.False(_))
                    )
                    .Select();

            value.Match(
                success: (_) => Assert.False(_),
                failure: (error) => throw new Exception("It should not run this block")
            );
        }
    }
}
