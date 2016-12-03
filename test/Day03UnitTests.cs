using System;
using Xunit;
using AdventOfCode1016;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode1016Tests
{
    public class Day03UnitTests
    {
        
        [Fact]
        public void Triangle_With_Sides_5_10_25_Is_Not_A_Triangle() 
        {
            var input = "5  10  25";
            var d = new Day03(input);
            d.ParseTriangles();
            Assert.Equal(0, d.NumberOfPossibleTriangles);
        }

        [Fact]
        public void Triangle_With_Sides_5_5_5_Is_A_Triangle() 
        {
            var input = "5  5  5";
            var d = new Day03(input);
            d.ParseTriangles();
            Assert.Equal(1, d.NumberOfPossibleTriangles);
        }

        [Fact]
        public void Triangle_With_Sides_775_785_361_And_Whitespaces_In_Input_Is_A_Triangle() 
        {
            var input = "  775  785  361";
            var d = new Day03(input);
            d.ParseTriangles();
            Assert.Equal(1, d.NumberOfPossibleTriangles);
        }

        [Fact]
        public void No_Triangles_From_Input_Should_Return_0() 
        {
            var input = "5  10  25\n5  10  25";
            var d = new Day03(input);
            d.ParseTriangles();
            Assert.Equal(0, d.NumberOfPossibleTriangles);
        }

        [Fact]
        public void Triangles_From_Input_Should_Return_2() 
        {
            var input = "5  5  5\n5  5  5";
            var d = new Day03(input);
            d.ParseTriangles();
            Assert.Equal(2, d.NumberOfPossibleTriangles);
        }

    }
}
