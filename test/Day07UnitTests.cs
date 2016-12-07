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
        
        [Theory]
        [InlineData("abba")]
        [InlineData("abba[mnop]qrst")] // abba[mnop]qrst supports TLS (abba outside square brackets).
        [InlineData("ioxxoj[asdfgh]zxcvbn")] // ioxxoj[asdfgh]zxcvbn supports TLS (oxxo is outside square brackets, even though it's within a larger string).
        [InlineData("rxpusykufgqujfe[rypwoorxdemxffui]cvvcufcqmxoxcphp[witynplrfvquduiot]vcysdcsowcxhphp[gctucefriclxaonpwe]jdprpdvpeumrhokrcjt")]
        public void Has_ABBA_Input_Should_Return_True(string input) 
        {
            Assert.Equal(true, Day07.HasABBA(input));
        }

        [Theory]
        [InlineData("aaaa")]
        [InlineData("abcd[bddb]xyyx")] // abcd[bddb]xyyx does not support TLS (bddb is within square brackets, even though xyyx is outside square brackets).
        [InlineData("aaaa[qwer]tyui")] // aaaa[qwer]tyui does not support TLS (aaaa is invalid; the interior characters must be different).
        [InlineData("unfjgussbjxzlhopoqg[ppdnqkiuooukdmbqlo]flfiieiitmettblfln")]
        [InlineData("ivjfulhqfbdqiprzbbe[ezhkhqxcviwxbwmlnbb]ttekmmdrphuteslzwcj[iocuduwexawydww]qmrfnnedqtqezclpuq")]
        public void Has_ABBA_Input_Should_Return_False(string input) 
        {
            Assert.Equal(false, Day07.HasABBA(input));
        }

        [Fact]
        public void Input_Should_Return_2_IPs_Supporting_TLS() 
        {
            var input = @"ioxxoj[asdfgh]zxcvbn
            aaaa[qwer]tyui
            abcd[bddb]xyyx
            abba[mnop]qrst
            ";
            var d07 = new Day07(input);
            Assert.Equal(2, d07.NumberOfIpsSupportingTLS);
        }
        
        [Theory]
        [InlineData("aba[bab]xyz")]
        [InlineData("aaa[kek]eke")]
        [InlineData("zazbz[bzb]cdb")]
        public void Has_ABA_Input_Should_Return_True(string input)
        {
            Assert.Equal(true, Day07.HasABA(input));
        }

        [Theory]
        [InlineData("xyx[xyx]xyx")]
        [InlineData("uxtugntiubziynpzbju[onxffxfoxibzzzd]wineojjetzitpemflx[jlncrpyrujpoxluwyc]fxvfnhyqsiwndzoh[lkwwatmiesspwcqulnc]cbimtxmazbbzlvjf")]
        public void Has_Not_ABA_Input_Should_Return_False(string input)
        {
            Assert.Equal(false, Day07.HasABA(input));
        }

        [Fact]
        public void Input_Should_Return_3_IPs_Supporting_SSL() 
        {
            var input = @"aba[bab]xyz
            xyx[xyx]xyx
            aaa[kek]eke
            zazbz[bzb]cdb
            ";
            var d07 = new Day07(input);
            Assert.Equal(3, d07.NumberOfIpsSupportingSSL);
        }

    }
}
