using System;
using Xunit;
using AdventOfCode1016;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode1016Tests
{
    public class Day23UnitTests
    {
        [Fact]
        public void Run_Test_Program_1_Should_Return_Register_A_Contains_0() 
        {
            var input = @"tgl a";
            var c = new Computerv2();
            c.LoadProgramFromString(input);
            c.Run();
            Assert.Equal(0, c.RegisterA);
            Assert.Equal("inc a", c.Program[0]);
        }
        
        [Fact]
        public void Run_Test_Program_2_Should_Return_Register_A_Contains_2() 
        {
            var input = @"tgl a
            jnz a 5
            inc a
            jnz a -3";
            var c = new Computerv2(0, 1);
            c.LoadProgramFromString(input);
            c.Run();
            Assert.Equal(2, c.RegisterA);
            Assert.Equal("inc a", c.Program[0]);
        }
        
        [Fact]
        public void Run_Test_Wrong_Instruction_Of_Program_3_Should_Return_Register_A_Contains_0() 
        {
            var input = @"cpy 1 2";
            var c = new Computerv2(0, 1);
            c.LoadProgramFromString(input);
            c.Run();
            Assert.Equal(0, c.RegisterA);
        }
        
        [Fact]
        public void Run_Test_Program_4_Should_Return_Register_A_Contains_3() 
        {
            var input = @"cpy 2 a
tgl a
tgl a
tgl a
cpy 1 a
dec a
dec a";
            var c = new Computerv2();
            c.LoadProgramFromString(input);
            c.Run();
            Assert.Equal(3, c.RegisterA);
        }
    }
}
