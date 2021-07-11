using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Functions.Number
{
    public class WhereTest
    {
        // I hate my life 
        
        [Fact]
        public void Should_Select_sbyte()
        {
            sbyte number = 10;

            var query = 
                from x in number
                where x == 10
                select x;
            
            query.
                Match(
                    _ => Assert.True(true),
                    (_) => throw new Exception("It should not run this block")
                );

            // With custom exception
            number
                .Where(x => x == 10, new Exception("Value must be equal to 10"))
                .Select()
                .Match(
                    _ => Assert.True(true),
                    (_) => throw new Exception("It should not run this block")
                );
        }

        [Fact]
        public void Should_Not_Select_sbyte()
        {
            sbyte number = 10;

            var query = 
                from x in number
                where x == 11
                select x;
            
            query.
                Match(
                    _ => throw new Exception("It should not run this block"),
                    (_) => Assert.True(true)
                );
        }

        [Fact]
        public void Should_Select_byte()
        {
            byte number = 10;
            
            var query = 
                from x in number
                where x == 10
                select x;
            
            query.
                Match(
                    _ => Assert.True(true),
                    (_) => throw new Exception("It should not run this block")
                );

            // With custom exception
            number
                .Where(x => x == 10, new Exception("Value must be equal to 10"))
                .Select()
                .Match(
                    _ => Assert.True(true),
                    (_) => throw new Exception("It should not run this block")
                );
        }

        [Fact]
        public void Should_Select_short()
        {
            short number = 10;
            
            var query = 
                from x in number
                where x == 10
                select x;
            
            query.
                Match(
                    _ => Assert.True(true),
                    (_) => throw new Exception("It should not run this block")
                );

            // With custom exception
            number
                .Where(x => x == 10, new Exception("Value must be equal to 10"))
                .Select()
                .Match(
                    _ => Assert.True(true),
                    (_) => throw new Exception("It should not run this block")
                );
        }

        [Fact]
        public void Should_Select_ushort()
        {
            ushort number = 10;
            
            var query = 
                from x in number
                where x == 10
                select x;
            
            query.
                Match(
                    _ => Assert.True(true),
                    (_) => throw new Exception("It should not run this block")
                );

            // With custom exception
            number
                .Where(x => x == 10, new Exception("Value must be equal to 10"))
                .Select()
                .Match(
                    _ => Assert.True(true),
                    (_) => throw new Exception("It should not run this block")
                );
        }

        [Fact]
        public void Should_Select_int()
        {
            int number = 10;
            
            var query = 
                from x in number
                where x == 10
                select x;
            
            query.
                Match(
                    _ => Assert.True(true),
                    (_) => throw new Exception("It should not run this block")
                );

            // With custom exception
            number
                .Where(x => x == 10, new Exception("Value must be equal to 10"))
                .Select()
                .Match(
                    _ => Assert.True(true),
                    (_) => throw new Exception("It should not run this block")
                );
        }

        [Fact]
        public void Should_Select_uint()
        {
            uint number = 10;
            
            var query = 
                from x in number
                where x == 10
                select x;
            
            query.
                Match(
                    _ => Assert.True(true),
                    (_) => throw new Exception("It should not run this block")
                );

            // With custom exception
            number
                .Where(x => x == 10, new Exception("Value must be equal to 10"))
                .Select()
                .Match(
                    _ => Assert.True(true),
                    (_) => throw new Exception("It should not run this block")
                );
        }

        [Fact]
        public void Should_Select_long()
        {
            long number = 10;
            
            var query = 
                from x in number
                where x == 10
                select x;
            
            query.
                Match(
                    _ => Assert.True(true),
                    (_) => throw new Exception("It should not run this block")
                );

            // With custom exception
            number
                .Where(x => x == 10, new Exception("Value must be equal to 10"))
                .Select()
                .Match(
                    _ => Assert.True(true),
                    (_) => throw new Exception("It should not run this block")
                );
        }

        [Fact]
        public void Should_Select_ulong()
        {
            ulong number = 10;
            
            var query = 
                from x in number
                where x == 10
                select x;
            
            query.
                Match(
                    _ => Assert.True(true),
                    (_) => throw new Exception("It should not run this block")
                );

            // With custom exception
            number
                .Where(x => x == 10, new Exception("Value must be equal to 10"))
                .Select()
                .Match(
                    _ => Assert.True(true),
                    (_) => throw new Exception("It should not run this block")
                );
        }

        [Fact]
        public void Should_Select_float()
        {
            float number = 10;
            
            var query = 
                from x in number
                where x == 10
                select x;
            
            query.
                Match(
                    _ => Assert.True(true),
                    (_) => throw new Exception("It should not run this block")
                );

            // With custom exception
            number
                .Where(x => x == 10, new Exception("Value must be equal to 10"))
                .Select()
                .Match(
                    _ => Assert.True(true),
                    (_) => throw new Exception("It should not run this block")
                );
        }

        [Fact]
        public void Should_Select_double()
        {
            double number =  10;
            
            var query = 
                from x in number
                where x == 10
                select x;
            
            query.
                Match(
                    _ => Assert.True(true),
                    (_) => throw new Exception("It should not run this block")
                );

            // With custom exception
            number
                .Where(x => x == 10, new Exception("Value must be equal to 10"))
                .Select()
                .Match(
                    _ => Assert.True(true),
                    (_) => throw new Exception("It should not run this block")
                );
        }

        [Fact]
        public void Should_Select_decimal()
        {
            decimal number = 10;
            
            var query = 
                from x in number
                where x == 10
                select x;
            
            query.
                Match(
                    _ => Assert.True(true),
                    (_) => throw new Exception("It should not run this block")
                );

            // With custom exception
            number
                .Where(x => x == 10, new Exception("Value must be equal to 10"))
                .Select()
                .Match(
                    _ => Assert.True(true),
                    (_) => throw new Exception("It should not run this block")
                );
        }
    }
}
