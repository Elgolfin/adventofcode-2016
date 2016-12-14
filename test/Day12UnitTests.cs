using System;
using Xunit;
using AdventOfCode1016;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode1016Tests
{
    public class Day12UnitTests
    {
        /*
        [Theory]
        [InlineData("abba")]
        [InlineData("abba[mnop]qrst")] // abba[mnop]qrst supports TLS (abba outside square brackets).
        [InlineData("ioxxoj[asdfgh]zxcvbn")] // ioxxoj[asdfgh]zxcvbn supports TLS (oxxo is outside square brackets, even though it's within a larger string).
        [InlineData("rxpusykufgqujfe[rypwoorxdemxffui]cvvcufcqmxoxcphp[witynplrfvquduiot]vcysdcsowcxhphp[gctucefriclxaonpwe]jdprpdvpeumrhokrcjt")]
        public void Has_ABBA_Input_Should_Return_True(string input) 
        {
            Assert.Equal(true, Day07.HasABBA(input));
        }
        */
/*
        [Fact]
        public void Run_Test_Program_1_Should_Return_Register_A_Contains_42() 
        {
            var input = @"cpy 41 a
inc a
inc a
dec a
jnz a 2
dec a";
            var c = new Computer();
            c.LoadProgramFromString(input);
            c.Run();
            Assert.Equal(42, c.RegisterA);
        }

        [Fact]
        public void Run_Test_Program_2_Should_Return_Register_properly_Initialized() 
        {
            var input = @"cpy 1 a
cpy 2 b
cpy 3 c
cpy 4 d";
            var c = new Computer();
            c.LoadProgramFromString(input);
            c.Run();
            Assert.Equal(1, c.RegisterA);
            Assert.Equal(2, c.RegisterB);
            Assert.Equal(3, c.RegisterC);
            Assert.Equal(4, c.RegisterD);
        }
        
        [Fact]
        public void Run_Test_Program_3_Should_Return_Register_A_Equals_To_Register_B() 
        {
            var input = @"cpy 19 a
cpy a b
";
            var c = new Computer();
            c.LoadProgramFromString(input);
            c.Run();
            Assert.Equal(19, c.RegisterA);
            Assert.Equal(19, c.RegisterB);
        }

        [Fact]
        public void Run_Test_Program_4_Should_Return_Increment_Register_A_To_2() 
        {
            var input = @"cpy 1 a
inc a
";
            var c = new Computer();
            c.LoadProgramFromString(input);
            c.Run();
            Assert.Equal(2, c.RegisterA);
        }

        [Fact]
        public void Run_Test_Program_4_Should_Return_Decrement_Register_A_Minus_1() 
        {
            var input = @"dec a
";
            var c = new Computer();
            c.LoadProgramFromString(input);
            c.Run();
            Assert.Equal(-1, c.RegisterA);
        }

        [Fact]
        public void Run_Test_Program_5_Should_Return_Increment_Register_A_To_2() 
        {
            var input = @"inc a
inc a
jnz a 2
inc a
";
            var c = new Computer();
            c.LoadProgramFromString(input);
            c.Run();
            Assert.Equal(2, c.RegisterA);
        }

        [Fact]
        public void Run_Test_Program_6_Should_Return_Increment_Register_A_To_3() 
        {
            var input = @"inc a
inc a
jnz a 1
inc a
";
            var c = new Computer();
            c.LoadProgramFromString(input);
            c.Run();
            Assert.Equal(3, c.RegisterA);
        }

        [Fact]
        public void Run_Test_Program_7_Should_Return_Increment_Register_A_To_2() 
        {
            var input = @"inc a
inc a
jnz a 2
inc a
";
            var c = new Computer();
            c.LoadProgramFromString(input);
            c.Run();
            Assert.Equal(2, c.RegisterA);
        }
        
        [Fact]
        public void Run_Test_Program_8_Should_Return_Decrement_Register_A_From_10_To_0() 
        {
            var input = @"cpy 10 a
dec a
jnz a -1
";
            var c = new Computer();
            c.LoadProgramFromString(input);
            c.Run();
            Assert.Equal(0, c.RegisterA);
        }



        [Fact]
        public void Run_Test_Program_9_Should_Return_Increment_Register_A_To_3() 
        {
            var input = @"inc a
inc a
jnz 0 2
inc a
";
            var c = new Computer();
            c.LoadProgramFromString(input);
            c.Run();
            Assert.Equal(3, c.RegisterA);
        }*/
    }
}