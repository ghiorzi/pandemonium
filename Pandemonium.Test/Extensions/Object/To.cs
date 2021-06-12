using Xunit;
using System;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Object
{
    public class ToTest
    {
        [Fact]
        public void Should_Cast_When_String_To_Object() 
        {
            string value = "anything";
            object result = value.To<object>();

            Assert.NotNull(result);
        }

        [Fact]
        public void Should_Not_Have_Value_When_Int_To_String() 
        {
            int value = 0;

            value
                .To<string>()
                .Match(
                    value: _ => throw new Exception("It should not run this block"),
                    empty: () => Assert.True(true)
                );
        } 

        [Fact]
        public void Should_Not_Have_Value_When_Value_Is_Null() 
        {
            string value = null;

            value
                .To<object>()
                .Match(
                    value: _ => throw new Exception("It should not run this block"),
                    empty: () => Assert.True(true)
                );
        } 
    }
}
