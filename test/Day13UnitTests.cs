using System;
using Xunit;
using AdventOfCode1016;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode1016Tests
{
    public class Day13UnitTests
    {
        
        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 1)]
        [InlineData(0, 4)]
        [InlineData(0, 5)]
        [InlineData(1, 1)]
        [InlineData(1, 2)]
        [InlineData(1, 5)]
        [InlineData(1, 6)]
        [InlineData(2, 0)]
        [InlineData(2, 2)]
        [InlineData(2, 6)]
        public void Test_If_Coordinates_Should_Be_An_Open_Space_Should_Return_True(int x, int y) 
        {
            var d13 = new Day13(0, 0, 10, 10, 10);
            Assert.Equal(true, d13.IsOpenSpace(x, y));
        }

        [Theory]
        [InlineData(0, 2)]
        [InlineData(0, 3)]
        [InlineData(0, 6)]
        [InlineData(1, 0)]
        [InlineData(1, 3)]
        [InlineData(1, 4)]
        [InlineData(2, 1)]
        [InlineData(2, 3)]
        [InlineData(2, 4)]
        [InlineData(2, 5)]
        public void Test_If_Coordinates_Should_Be_A_Wall_Should_Return_True(int x, int y) 
        {
            var d13 = new Day13(0, 0, 10, 10, 10);
            Assert.Equal(true, d13.IsWall(x, y));
        }
        
        
        [Fact]
        public void Test_Should_Return_Something() 
        {
            var expected = @".#.####.##
..#..#...#
#....##...
###.#.###.
.##..#..#.
..##....#.
#...##.###
.##..#.##.
#.###....#
###.####.#
";
            var d13 = new Day13(0, 0, 10, 10, 10);
            Assert.Equal(expected, d13.DrawMap());
        }
        
        [Theory]
        [InlineData(0, 0, 1)]
        [InlineData(1, 0, 3)]
        [InlineData(1, 1, 2)]
        [InlineData(0, 1, 2)]
        public void Test_Should_Return_The_Right_Number_Of_Connected_Open_Spaces(int x, int y, int countConnectedOpenSpaces) 
        {
            var d13 = new Day13(0, 0, 10, 10, 10);
            var list = d13.GetAllConnectedOpenSpaces(new Coordinate(x, y));
            Assert.Equal(countConnectedOpenSpaces, list.Count);
        }

        
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 1, 2)]
        [InlineData(3, 2, 5)]
        public void Path_To_Coordinate_With_Root_0_0_Should_Return_The_Good_Length(int x, int y, int expectedLength) {
            var d13 = new Day13(0, 0, 10, 10, 10);
            Assert.Equal(expectedLength, d13.Maze[$"{x},{y}"].DistanceFromRoot);
        }

        [Theory]
        [InlineData(7, 4, 11)]
        public void Path_To_Coordinate_With_Root_1_1_Should_Return_The_Good_Length(int x, int y, int expectedLength) {
            var d13 = new Day13(1, 1, 10, 10, 10);
            Assert.Equal(expectedLength, d13.Maze[$"{x},{y}"].DistanceFromRoot);
        }
        
    }
}
