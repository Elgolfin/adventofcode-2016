using System;
using Xunit;
using AdventOfCode1016;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode1016Tests
{

    public class Day24UnitTests
    {
        [Theory]
        [InlineData("a", 1)]
        [InlineData("ab", 2)]
        [InlineData("abc", 6)]      // Or 3! (Factorial 3)
        [InlineData("abcd", 24)]     // Or 4! (Factorial 4)
        [InlineData("abcde", 120)]  // Or 5! (Factorial 5)
        public void All_Combinations_Of_Input_Should_Return_The_Right_Number_Of_Permutations(string input, int numOfExpectedPermutations) 
        {
            Assert.Equal(numOfExpectedPermutations, Day24.GetAllPermutations(input).Count);
        }

        [Fact]
        public void All_Combinations_Of_1_2_3_Should_Return_6_Different_Combinations() 
        {
            var input = "123";
            var permutations = Day24.GetAllPermutations(input);
            Assert.Equal(new List<string>(){"123", "132", "213", "231", "312", "321"}, permutations);
        }
        
        [Fact]
        public void Load_The_Input_Map_As_String_Should_Return_A_Map_Of_55_Locations_1() 
        {
            var input = @"###########
#0.1.....2#
#.#######.#
#4.......3#
###########";
            var d24 = new Day24(input);
            Assert.Equal(55, d24.Map.Count());
        }

        [Theory]
        [InlineData('0', '4', 2)]
        [InlineData('4', '1', 4)]
        [InlineData('1', '2', 6)]
        [InlineData('2', '3', 2)]
        public void Load_The_Input_Map_As_String_Should_Return_A_Map_Of_55_Locations(char from, char to, int expectedDistance) 
        {
            var input = @"###########
#0.1.....2#
#.#######.#
#4.......3#
###########";
            var d24 = new Day24(input);
            Assert.Equal(expectedDistance, d24.FindShortestDistance(from, to));
        }

        [Fact]
        public void Find_Shortest_Distance_Between_All_Destinations_Should_Return_14_Steps ()
        {
            var input = @"###########
#0.1.....2#
#.#######.#
#4.......3#
###########";
            var d24 = new Day24(input);
            Assert.Equal(14, d24.FindFewestStepsBetweenAllDestinations("01234"));
            Assert.Equal('3', d24.LastRoundTripLocation);
        }

        [Fact]
        public void Find_Shortest_Distance_Between_All_Destinations_And_Returning_To_Starting_Point_Should_Return_20_Steps ()
        {
            var input = @"###########
#0.1.....2#
#.#######.#
#4.......3#
###########";
            var d24 = new Day24(input);
            Assert.Equal(20, d24.FindFewestStepsBetweenAllDestinations("01234", '0', true));
            Assert.Equal('0', d24.LastRoundTripLocation);
        }
    }
}
