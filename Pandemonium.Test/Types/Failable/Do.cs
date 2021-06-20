using Xunit;
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
                    .Do<bool>((_) => _)
                    .Do<bool>((_) => _)
                    .Do<bool>((_) => _);

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
                    .Do<bool>((_) => false)
                    .Do<bool>((_) => new Exception("Do not run the next action"))
                    .Do<bool>((_) => true);

            value.Match(
                success: (_) => throw new Exception("Test has failed. It should not do the last action"),
                failure: (error) => Assert.Equal("Do not run the next action", error.Message)
            );
        }
    }
}
