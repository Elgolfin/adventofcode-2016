using System;
using Xunit;
using AdventOfCode1016;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode1016Tests
{
    public class Day20UnitTests
    {
        [Fact]
        public void Blocked_IPs_List_Should_Return_A_List_Of_3_Sorted() 
        {
            var input = @"5-8
0-2
4-7";
            var d20 = new Day20(input);
            Assert.Equal(3, d20.BlockedIPs.Count);
            Assert.Equal(0U, d20.BlockedIPs[0].LowerBound);
            Assert.Equal(4U, d20.BlockedIPs[1].LowerBound);
            Assert.Equal(5U, d20.BlockedIPs[2].LowerBound);
        }

        [Fact]
        public void Smallest_IP_Allowed_Should_Return_3() 
        {
            var input = @"5-8
0-2
4-7";
            var d20 = new Day20(input);
            uint expected = 3;
            Assert.Equal(expected, d20.GetLowestValuedOFNotBlockedIPs());
        }

        [Fact]
        public void Count_Allowed_IPs_Should_Return_4294967288() 
        {
            var input = @"5-8
0-2
4-7";
            var d20 = new Day20(input);
            long expected = 4294967296 - 8;
            Assert.Equal(expected, d20.GetAllAllowedIPs());
        }

        [Fact]
        public void Count_Allowed_IPs_Should_Return_4294967286() 
        {
            var input = @"1-10";
            var d20 = new Day20(input);
            long expected = 4294967296 - 10;
            Assert.Equal(expected, d20.GetAllAllowedIPs());
        }
    }
}
