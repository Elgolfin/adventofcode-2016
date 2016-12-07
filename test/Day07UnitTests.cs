using System;
using Xunit;
using AdventOfCode1016;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode1016Tests
{
    public class Day07UnitTests
    {
        
        [Fact]
        public void Has_ABBA_Input_abba_Should_Return_true() 
        {
            var input = "abba";
            Assert.Equal(true, Day07.HasABBA(input));
        }

        [Fact]
        public void Has_ABBA_Input_aaaa_Should_Return_false() 
        {
            var input = "aaaa";
            Assert.Equal(false, Day07.HasABBA(input));
        }

        // abba[mnop]qrst supports TLS (abba outside square brackets).
        [Fact]
        public void Has_ABBA_Input_1_Should_Return_true() 
        {
            var input = "abba[mnop]qrst";
            Assert.Equal(true, Day07.HasABBA(input));
        }

        // abcd[bddb]xyyx does not support TLS (bddb is within square brackets, even though xyyx is outside square brackets).
        [Fact]
        public void Has_ABBA_Input_2_Should_Return_true() 
        {
            var input = "abcd[bddb]xyyx";
            Assert.Equal(false, Day07.HasABBA(input));
        }

        // aaaa[qwer]tyui does not support TLS (aaaa is invalid; the interior characters must be different).
        [Fact]
        public void Has_ABBA_Input_3_Should_Return_true() 
        {
            var input = "aaaa[qwer]tyui";
            Assert.Equal(false, Day07.HasABBA(input));
        }

        // ioxxoj[asdfgh]zxcvbn supports TLS (oxxo is outside square brackets, even though it's within a larger string).
        [Fact]
        public void Has_ABBA_Input_4_Should_Return_true() 
        {
            var input = "ioxxoj[asdfgh]zxcvbn";
            Assert.Equal(true, Day07.HasABBA(input));
        }
        
        [Fact]
        public void Has_ABBA_Input_5_Should_Return_true() 
        {
            var input = "rxpusykufgqujfe[rypwoorxdemxffui]cvvcufcqmxoxcphp[witynplrfvquduiot]vcysdcsowcxhphp[gctucefriclxaonpwe]jdprpdvpeumrhokrcjt";
            Assert.Equal(true, Day07.HasABBA(input));
        }

        [Fact]
        public void Has_ABBA_Input_6_Should_Return_false() 
        {
            var input = "unfjgussbjxzlhopoqg[ppdnqkiuooukdmbqlo]flfiieiitmettblfln";
            Assert.Equal(false, Day07.HasABBA(input));
        }

        [Fact]
        public void Has_ABBA_Input_7_Should_Return_false() 
        {
            var input = "ivjfulhqfbdqiprzbbe[ezhkhqxcviwxbwmlnbb]ttekmmdrphuteslzwcj[iocuduwexawydww]qmrfnnedqtqezclpuq";
            Assert.Equal(false, Day07.HasABBA(input));
        }
        

        [Fact]
        public void Input_Should_Return_Two_IPs_Supporting_TLS() 
        {
            var input = @"ioxxoj[asdfgh]zxcvbn
            aaaa[qwer]tyui
            abcd[bddb]xyyx
            abba[mnop]qrst
            ";
            var d07 = new Day07(input);
            Assert.Equal(2, d07.NumberOfIpsSupportingTLS);
        }
        

    }
}
