using System;
using Xunit;
using AdventOfCode1016;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode1016Tests
{
    public class Day06UnitTests
    {
        
        [Fact]
        public void Parse_Input_Should_Return_Data_Oraganized_Properly() 
        {
            var input = @"eadadn
drvter
eadadr";
            var expected = new Dictionary<int, Dictionary<char, int>>() {
                {0, new Dictionary<char, int>() {{'e', 2}, {'d', 1}}},
                {1, new Dictionary<char, int>() {{'a', 2}, {'r', 1}}},
                {2, new Dictionary<char, int>() {{'d', 2}, {'v', 1}}},
                {3, new Dictionary<char, int>() {{'a', 2}, {'t', 1}}},
                {4, new Dictionary<char, int>() {{'d', 2}, {'e', 1}}},
                {5, new Dictionary<char, int>() {{'n', 1}, {'r', 2}}}
            };
            var d06 = new Day06(input);
            Assert.Equal(expected, d06.Columns);
        }

        [Fact]
        public void Get_Message_Desc_Should_Return_easter() 
        {
            var input = @"eedadn
drvtee
eandsr
raavrd
atevrs
tsrnev
sdttsa
rasrtv
nssdts
ntnada
svetve
tesnvt
vntsnd
vrdear
dvrsen
enarar";
            var expected = "easter";
            var d06 = new Day06(input);
            d06.GetMessage();
            Assert.Equal(expected, d06.Message);
        }

        [Fact]
        public void Get_Message_Asc_Should_Return_easter() 
        {
            var input = @"eedadn
drvtee
eandsr
raavrd
atevrs
tsrnev
sdttsa
rasrtv
nssdts
ntnada
svetve
tesnvt
vntsnd
vrdear
dvrsen
enarar";
            var expected = "advent";
            var d06 = new Day06(input);
            d06.GetMessage(Day06.OrderBy.Asc);
            Assert.Equal(expected, d06.Message);
        }

    }
}
