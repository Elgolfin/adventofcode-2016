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
        public void Blocked_IPs_List_Should_Return_3() 
        {
            var input = @"5-8
0-2
4-7";
            var d20 = new Day20(input);
            Assert.Equal(3, d20.BlockedIPs.Count);
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
    }
}
