using System;
using Xunit;
using AdventOfCode1016;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode1016Tests
{
    public class Day21UnitTests
    {
        /// Swap position 4 with position 0 swaps the first and last letters, producing the input for the next step, ebcda.
        [Fact]
        public void Swap_Position_4_With_Position_0_Of_abcde_Should_Return_ebcda() 
        {
            Assert.Equal("ebcda", "abcde".SwapPositionXWithPositionY(4, 0));
        }

        /// Swap letter d with letter b swaps the positions of d and b: edcba.
        [Fact]
        public void Swap_Letter_d_With_Letter_b_Of_ebcda_Should_Return_edcba() 
        {
            Assert.Equal("edcba", "ebcda".SwapLetterXWithLetterY('d', 'b'));
        }

        /// Reverse positions 0 through 4 causes the entire string to be reversed, producing abcde.
        [Fact]
        public void Reverse_Position_0_Through_4_Of_ebcda_Should_Return_edcba() 
        {
            Assert.Equal("abcde", "edcba".ReversePosition(0, 4));
        }

        /// Rotate left 1 step shifts all letters left one position, causing the first letter to wrap to the end of the string: bcdea.
        [Fact]
        public void Rotate_Left_1_Of_abcde_Should_Return_bcdea() 
        {
            Assert.Equal("bcdea", "abcde".RotateLeft(1));
        }

        
        [Theory]
        [InlineData(0, "abcde")]
        [InlineData(1, "bcdea")]
        [InlineData(2, "cdeab")]
        [InlineData(3, "deabc")]
        [InlineData(4, "eabcd")]
        [InlineData(5, "abcde")]
        [InlineData(6, "bcdea")]
        public void Rotate_Left_X_Steps_Of_abcde_Should_Return_The_Right_String(int x, string expectedResult) 
        {
            Assert.Equal(expectedResult, "abcde".RotateLeft(x));
        }

        /// Rotate Right 1 step shifts all letters right one position, causing the last letter to wrap to the beginning of the string: eabcd.
        [Fact]
        public void Rotate_Right_1_Of_abcde_Should_Return_eabcd() 
        {
            Assert.Equal("eabcd", "abcde".RotateRight(1));
        }
        
        [Theory]
        [InlineData(0, "abcde")]
        [InlineData(1, "eabcd")]
        [InlineData(2, "deabc")]
        [InlineData(3, "cdeab")]
        [InlineData(4, "bcdea")]
        [InlineData(5, "abcde")]
        [InlineData(6, "eabcd")]
        public void Rotate_Right_X_Steps_Of_abcde_Should_Return_The_Right_String(int x, string expectedResult) 
        {
            Assert.Equal(expectedResult, "abcde".RotateRight(x));
        }

        /// Move position 1 to position 4 removes the letter at position 1 (c), then inserts it at position 4 (the end of the string): bdeac.
        [Fact]
        public void Move_Position_1_To_Position_4_Of_bcdea_Should_Return_bcdea() 
        {
            Assert.Equal("bdeac", "bcdea".MovePosition(1, 4));
        }

        /// Move position 3 to position 0 removes the letter at position 3 (a), then inserts it at position 0 (the front of the string): abdec.
        [Fact]
        public void Move_Position_3_To_Position_0_Of_bdeac_Should_Return_abdec() 
        {
            Assert.Equal("abdec", "bdeac".MovePosition(3, 0));
        }

        /// Rotate based on position of letter b finds the index of letter b (1), then rotates the string right once plus a number of times equal to that index (2): ecabd.
        [Fact]
        public void Rotate_Based_On_Position_Of_Letter_b_Of_abdec_Should_Return_ecabd() 
        {
            Assert.Equal("ecabd", "abdec".RotateBasedOnPosition('b'));
        }
        
        /// Rotate based on position of letter d finds the index of letter d (4), then rotates the string right once, plus a number of times equal to that index, plus an additional time because the index was at least 4, for a total of 6 right rotations: decab.
        [Fact]
        public void Rotate_Based_On_Position_Of_Letter_d_Of_ecabd_Should_Return_decab() 
        {
            Assert.Equal("decab", "ecabd".RotateBasedOnPosition('d'));
        }

        [Fact]
        public void Run_Instructions_Of_abcde_Should_Return_decab() 
        {
            var input = @"swap position 4 with position 0
            swap letter d with letter b
            reverse positions 0 through 4
    rotate left 1 step

    
    move position 1 to position 4
    move position 3 to position 0
    rotate based on position of letter b
    rotate based on position of letter d
    ";
            var d21 = new Day21(input, "abcde");
            Assert.Equal("decab", d21.ScramblingStr);
        }    
    }
}
