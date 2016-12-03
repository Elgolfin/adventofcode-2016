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

        [Fact]
        public void Input_With_6_Vertical_Triangles_With_Many_Whitespaces_Should_Return_6() 
        {
            var input = @"101    301 501
102  302    502
103   303   503
201   401        601
202    402    602
203 403  603";
            var d = new Day03(input, true);
            Assert.Equal(6, d.Triangles.Length);
            Assert.Equal("101 102 103", d.Triangles[0]);
            Assert.Equal("301 302 303", d.Triangles[1]);
            Assert.Equal("501 502 503", d.Triangles[2]);
            Assert.Equal("201 202 203", d.Triangles[3]);
            Assert.Equal("401 402 403", d.Triangles[4]);
            Assert.Equal("601 602 603", d.Triangles[5]);
            d.ParseTriangles();
            Assert.Equal(6, d.NumberOfPossibleTriangles);
        }

        

    }
}
