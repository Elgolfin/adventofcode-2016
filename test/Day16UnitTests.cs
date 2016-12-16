using System;
using Xunit;
using AdventOfCode1016;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode1016Tests
{
    public class Day16UnitTests
    {
        [Theory]
        [InlineData("1", "100")]
        [InlineData("0", "001")]
        [InlineData("11111", "11111000000")]
        [InlineData("111100001010", "1111000010100101011110000")]
        public void Generate_Data_From_Various_Inputs_Should_Return_Expected_Results(string input, string expected) 
        {
            Assert.Equal(expected, Day16.GenerateData(input));
        }
        
        [Fact]
        public void Generate_Checksum_Of_String_110010110100_Should_Return_100() 
        {
            Assert.Equal("100", Day16.GenerateChecksum("110010110100"));
        }
        
        [Fact]
        public void Fill_Disk_Of_20_Bytes_With_Initial_State_10000_Should_Return_01100() 
        {
            Assert.Equal("01100", Day16.FillDisk("10000", 20));
        }

    }
}
