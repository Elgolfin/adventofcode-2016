using System;
using Xunit;
using AdventOfCode1016;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode1016Tests
{
    public class Day01UnitTests
    {
        [Fact]
        public void ParseString_R2_L2_R3_Should_Return_A_List_Of_3_Elements() 
        {
            var input = "R2, R2, L3";
            var d = new Day01(input);
            var expected = new List<String>{"R2", "R2", "L3"};
            Assert.Equal(expected, d.Path);
        }

        [Fact]
        public void Facing_North_R2_Should_Head_To_East_2_Blocks() 
        {
            var input = "";
            var d = new Day01(input);
            d.MoveTo("R2");
            Assert.Equal(Day01.Direction.East, d.HeadTo);
            Assert.Equal(2, d.x);
            Assert.Equal(0, d.y);
        }

        [Fact]
        public void Facing_North_L2_Should_Head_To_West_2_Blocks() 
        {
            var input = "";
            var d = new Day01(input);
            d.MoveTo("L2");
            Assert.Equal(Day01.Direction.West, d.HeadTo);
            Assert.Equal(-2, d.x);
            Assert.Equal(0, d.y);
        }

        [Fact]
        public void Facing_South_R2_Should_Head_To_West_2_Blocks() 
        {
            var input = "";
            var d = new Day01(input);
            d.HeadTo = Day01.Direction.South;
            d.MoveTo("R2");
            Assert.Equal(Day01.Direction.West, d.HeadTo);
            Assert.Equal(-2, d.x);
            Assert.Equal(0, d.y);
        }

        [Fact]
        public void Facing_South_L2_Should_Head_To_East_2_Blocks() 
        {
            var input = "";
            var d = new Day01(input);
            d.HeadTo = Day01.Direction.South;
            d.MoveTo("L2");
            Assert.Equal(Day01.Direction.East, d.HeadTo);
            Assert.Equal(2, d.x);
            Assert.Equal(0, d.y);
        }

        [Fact]
        public void Facing_East_R2_Should_Head_To_South_2_Blocks() 
        {
            var input = "";
            var d = new Day01(input);
            d.HeadTo = Day01.Direction.East;
            d.MoveTo("R2");
            Assert.Equal(Day01.Direction.South, d.HeadTo);
            Assert.Equal(-2, d.y);
            Assert.Equal(0, d.x);
        }

        [Fact]
        public void Facing_East_L2_Should_Head_To_North_2_Blocks() 
        {
            var input = "";
            var d = new Day01(input);
            d.HeadTo = Day01.Direction.East;
            d.MoveTo("L2");
            Assert.Equal(Day01.Direction.North, d.HeadTo);
            Assert.Equal(2, d.y);
            Assert.Equal(0, d.x);
        }

        [Fact]
        public void Facing_West_R2_Should_Head_To_North_2_Blocks() 
        {
            var input = "";
            var d = new Day01(input);
            d.HeadTo = Day01.Direction.West;
            d.MoveTo("R2");
            Assert.Equal(Day01.Direction.North, d.HeadTo);
            Assert.Equal(2, d.y);
            Assert.Equal(0, d.x);
        }

        [Fact]
        public void Facing_West_L2_Should_Head_To_South_2_Blocks() 
        {
            var input = "";
            var d = new Day01(input);
            d.HeadTo = Day01.Direction.West;
            d.MoveTo("L2");
            Assert.Equal(Day01.Direction.South, d.HeadTo);
            Assert.Equal(-2, d.y);
            Assert.Equal(0, d.x);
        }

        [Fact]
        public void Moving_R2_L3_Should_Return_5_Blocks_Away() 
        {
            var input = "R2, L3";
            var d = new Day01(input);
            d.MoveAlongThePath();
            Assert.Equal(5, d.GetBlocksAwayFromStart());
        }

        [Fact]
        public void Moving_R2_R2_R2_Should_Return_2_Blocks_Away() 
        {
            var input = "R2, R2, R2";
            var d = new Day01(input);
            d.MoveAlongThePath();
            Assert.Equal(2, d.GetBlocksAwayFromStart());
        }

        [Fact]
        public void Moving_R5_L5_R5_R3_Should_Return_12_Blocks_Away() 
        {
            var input = "R5, L5, R5, R3";
            var d = new Day01(input);
            d.MoveAlongThePath();
            Assert.Equal(12, d.GetBlocksAwayFromStart());
        }
        
    }
}
