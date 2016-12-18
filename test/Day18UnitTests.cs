using System;
using Xunit;
using AdventOfCode1016;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode1016Tests
{
    public class Day18UnitTests
    {
        
        [Theory]
        [InlineData("..^^.",".^^^^")]
        [InlineData(".^^^^","^^..^")]
        public void Discover_New_Row_Of_Tiles_Should_Return_The_Right_Tiles_As_Safe_Or_Trap(string previousRow, string expectedRow) 
        {
            var d18 = new Day18();
            Assert.Equal(expectedRow, d18.CreateRow(previousRow));
        }     

        [Theory]
        [InlineData('^', '^', '.', false)] // Its left and center tiles are traps, but its right tile is not.
        [InlineData('.', '^', '^', false)] // Its center and right tiles are traps, but its left tile is not.
        [InlineData('^', '.', '.', false)] // Only its left tile is a trap.
        [InlineData('.', '.', '^', false)] // Only its right tile is a trap.
        // In any other situation, the new tile is safe.
        [InlineData('.', '.', '.', true)]
        [InlineData('.', '^', '.', true)]
        [InlineData('^', '.', '^', true)]
        [InlineData('^', '^', '^', true)]
        public void Is_New_Tile_Safe_Should_Return_The_Expected_Output(char left, char center, char right, bool expectedResult) 
        {
            var d18 = new Day18();
            Assert.Equal(expectedResult, d18.IsNewTileSafe(left, center, right));
        }

        [Fact]
        public void Number_Of_Traps_With_First_Row_Within_A_Filed_Of_10_Rows_Should_Return_38_Safe_Tiles() 
        {
            var d18 = new Day18(".^^.^.^^^^");
            Assert.Equal(38, d18.GetNumberOfSafeTiles(10));

        }

    }
}
