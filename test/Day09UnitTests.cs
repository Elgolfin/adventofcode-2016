using System;
using Xunit;
using AdventOfCode1016;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode1016Tests
{
    public class Day09UnitTests
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

        [Fact]
        public void Decompress_ADVENT_Should_Return_ADVENT() 
        {
            var input = @"ADVENT";
            var d = new Day09(input);
            Assert.Equal("ADVENT", d.Decompress());
        }

        [Fact]
        public void Decompress_A_1x5_BC_Should_Return_ABBBBBC() 
        {
            var input = @"A(1x5)BC";
            var d = new Day09(input);
            Assert.Equal("ABBBBBC", d.Decompress());
        }

        [Fact]
        public void Decompress_3x3_XYZ_Should_Return_XYZXYZXYZ() 
        {
            var input = @"(3x3)XYZ";
            var d = new Day09(input);
            Assert.Equal("XYZXYZXYZ", d.Decompress());
        }

        [Fact]
        public void Decompress_A_2x2_BCD_2x2_EFG_Should_Return_ABCBCDEFEFG() 
        {
            var input = @"A(2x2)BCD(2x2)EFG";
            var d = new Day09(input);
            Assert.Equal("ABCBCDEFEFG", d.Decompress());
        }

        [Fact]
        public void Decompress__6x1__1x3_A_Should_Return_1x3_A() 
        {
            var input = @"(6x1)(1x3)A";
            var d = new Day09(input);
            Assert.Equal("(1x3)A", d.Decompress());
        }

        [Fact]
        public void Decompress_X_8x2__3x3_ABCY_Should_Return_X_3x3_ABC_3x3_ABCY() 
        {
            var input = @"X(8x2)(3x3)ABCY";
            var d = new Day09(input);
            Assert.Equal("X(3x3)ABC(3x3)ABCY", d.Decompress());
        }

    }
}
