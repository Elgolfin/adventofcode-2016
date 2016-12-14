using System;
using Xunit;
using AdventOfCode1016;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode1016Tests
{
    public class Day14UnitTests
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
        public void First_Index_To_Produce_A_Hash_With_3_Same_Consecutive_Characters_Should_Return_18() 
        {
            var d14 = new Day14("abc");
            var validHashIndexes = d14.FindValidHash();
            var validHashIndex = -1;
            foreach (var idx in validHashIndexes) {
                validHashIndex = idx;
                break;
            }
            Assert.Equal(18, validHashIndex);
        }
        */

        [Fact]
        public void Thousand_Hashes_Starting_At_18_And_Looking_For_5_7s_Should_Return_False() 
        {
            var d14 = new Day14("abc");
            Assert.Equal(false, d14.NextNHashesAreValid(18, '7', 1000));
        }

        [Fact]
        public void Thousand_Hashes_Starting_At_39_Should_Return_True() 
        {
            var d14 = new Day14("abc");
            Assert.Equal(true, d14.NextNHashesAreValid(39, 'e', 1000));
        }

        [Fact]
        public void Thousand_Hashes_Starting_At_92_Should_Return_True() 
        {
            var d14 = new Day14("abc");
            Assert.Equal(true, d14.NextNHashesAreValid(39, '9', 1000));
        }
        
        [Fact]
        public void _64th_Valid_Hash_Should_Be_Returned_At_Index_22728() 
        {
            var d14 = new Day14("abc");
            Assert.Equal(22728, d14.ReturnNthValidKey(64));
        }
        
        [Fact]
        public void MD5_Stretching_Hash_Should_Returned_The_Right_MD5_Hashes() 
        {
            var d14 = new Day14("abc");
            Assert.Equal("577571be4de9dcce85a041ba0410f29f", Day14.KeyStretchingMD5Hash("abc0", 0));
            Assert.Equal("eec80a0c92dc8a0777c619d9bb51e910", Day14.KeyStretchingMD5Hash("abc0", 1));
            Assert.Equal("16062ce768787384c81fe17a7a60c7e3", Day14.KeyStretchingMD5Hash("abc0", 2));
            Assert.Equal("a107ff634856bb300138cac6568c0f24", Day14.KeyStretchingMD5Hash("abc0", 2016));
        
        }

        [Fact]
        public void _1st_Valid_Hash_With_KeyStretchingEnabled_Should_Be_Returned_At_Index_10() 
        {
            var d14 = new Day14("abc", 2016);
            Assert.Equal(10, d14.ReturnNthValidKey(1));
        }
        
        [Fact]
        public void _64th_Valid_Hash_With_KeyStretchingEnabled_Should_Be_Returned_At_Index_22551() 
        {
            var d14 = new Day14("abc", 2016);
            Assert.Equal(22551, d14.ReturnNthValidKey(64));
        }
        
    }
}
