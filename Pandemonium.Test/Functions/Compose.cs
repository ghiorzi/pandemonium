using Xunit;
using System;
using static Pandemonium.Functions;

namespace Pandemonium.Test.FunctionsTest
{
    public class ComposeTest
    {
        [Fact]
        public void Should_Compose_Functions()
        {
            Func<string, string> AddName = _ => _ + " Rodrigo";
            Func<string, string> AddSurname = _ => _ + " Ghiorzi";

            var function = Compose<string>(AddSurname, AddName);

            Assert.Equal("Sr. Rodrigo Ghiorzi", function("Sr."));
        }

        [Fact]
        public void Should_Not_Run_Composed_Functions_Given_Lazy_Behaviour()
        {
            Func<string, string> AddName = _ => throw new NotImplementedException();
            Func<string, string> AddSurname = _ => throw new NotImplementedException();;

            var function = Compose<string>(AddSurname, AddName);

            // Since we did not call function, AddName and AddSurname will not be called either

            Assert.True(true);
        }
    }
}
