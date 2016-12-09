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
            Assert.Equal("ADVENT", d.DecompressedInput);
        }

        [Fact]
        public void Decompress_A_1x5_BC_Should_Return_ABBBBBC() 
        {
            var input = @"A(1x5)BC";
            var d = new Day09(input);
            Assert.Equal("ABBBBBC", d.DecompressedInput);
        }

        [Fact]
        public void Decompress_3x3_XYZ_Should_Return_XYZXYZXYZ() 
        {
            var input = @"(3x3)XYZ";
            var d = new Day09(input);
            Assert.Equal("XYZXYZXYZ", d.DecompressedInput);
        }

        [Fact]
        public void Decompress_A_2x2_BCD_2x2_EFG_Should_Return_ABCBCDEFEFG() 
        {
            var input = @"A(2x2)BCD(2x2)EFG";
            var d = new Day09(input);
            Assert.Equal("ABCBCDEFEFG", d.DecompressedInput);
        }

        [Fact]
        public void Decompress__6x1__1x3_A_Should_Return_1x3_A() 
        {
            var input = @"(6x1)(1x3)A";
            var d = new Day09(input);
            Assert.Equal("(1x3)A", d.DecompressedInput);
        }

        [Fact]
        public void Decompress_X_8x2__3x3_ABCY_Should_Return_X_3x3_ABC_3x3_ABCY() 
        {
            var input = @"X(8x2)(3x3)ABCY";
            var d = new Day09(input);
            Assert.Equal("X(3x3)ABC(3x3)ABCY", d.DecompressedInput);
        }

        [Fact]
        public void Decompress_v2_3x3_XYZ_Should_Return_XYZXYZXYZ() 
        {
            var input = @"(3x3)XYZ";
            var d = new Day09(input);
            Assert.Equal("XYZXYZXYZ", d.Decompress_v2());
        }

        [Fact]
        public void Decompress_v2_X_8x2__3x3_ABCY_Should_Return_XABCABCABCABCABCABCY() 
        {
            var input = @"X(8x2)(3x3)ABCY";
            var d = new Day09(input);
            Assert.Equal("XABCABCABCABCABCABCY", d.Decompress_v2());
        }

        [Fact]
        public void Decompress_v2__27x12__20x12__13x14__7x10__1x12_A_Should_Return_A_Repeated_241920_Times() 
        {
            var input = @"(27x12)(20x12)(13x14)(7x10)(1x12)A";
            var d = new Day09(input);
            Assert.Equal(241920, d.Decompress_v2().Length);
        }

        [Fact]
        public void Decompress_v2__25x3__3x3_ABC_2x3_XY_5x2_PQRSTX_18x9__3x2_TWO_5x7_SEVEN_Should_Return_A_Decompressed_String_Long_Of_445_Characters() 
        {
            var input = @"(25x3)(3x3)ABC(2x3)XY(5x2)PQRSTX(18x9)(3x2)TWO(5x7)SEVEN";
            var d = new Day09(input);
            Assert.Equal(445, d.Decompress_v2().Length);
        }

        [Fact]
        public void Decompress_v21__25x3__3x3_ABC_2x3_XY_5x2_PQRSTX_18x9__3x2_TWO_5x7_SEVEN_Should_Return_445() 
        {
            var input = @"(25x3)(3x3)ABC(2x3)XY(5x2)PQRSTX(18x9)(3x2)TWO(5x7)SEVEN";
            var d = new Day09(input);
            Assert.Equal(445U, d.Decompress_v21(input));
        }

        [Fact]
        public void Decompress_v2__27x12__20x12__13x14__7x10__1x12_A_Should_Return__241920() 
        {
            var input = @"(27x12)(20x12)(13x14)(7x10)(1x12)A";
            var d = new Day09(input);
            Assert.Equal(241920U, d.Decompress_v21(input));
        }

    }
}
