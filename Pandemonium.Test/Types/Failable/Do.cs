using Xunit;
using Pandemonium;
using Pandemonium.Types;
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
                    .Where(x => x < 20, new Exception("Value must be less than 20"))
                    .Do(() => Assert.True(true));

            _ =
                input
                    .Where(x => x < 20, new Exception("Value must be less than 20"))
                    .Do((x) => Assert.True(x == 10));
        }

        [Fact]
        public void Should_Not_Do()
        {
            Failable<int> input = 21;

            _ =
                input
                    .Where(x => x < 20, new Exception("Value must be less than 20"))
                    .Do(() => throw new Exception("Test has failed. It should not run this function"));

            _ =
                input
                    .Where(x => x < 20, new Exception("Value must be less than 20"))
                    .Do(() => throw new Exception("Test has failed. It should not run this function"));
        }

        [Fact]
        public void Should_Do_All_Actions()
        {
            Failable<bool> input = false;

            Failable<bool> value =
                input
                    .Do((_) => {})
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
                    .Do((_) => {})
                    .Do((_) => Assert.False(_))
                    .Select();

            value.Match(
                success: (_) => Assert.False(_),
                failure: (error) => throw new Exception("It should not run this block")
            );
        }
    }
}
