﻿using System;
using Xunit;
using AdventOfCode1016;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode1016Tests
{
    public class Day02UnitTests
    {
        
        // /////////////////////////////////////////////////
        // MOVING FROM 1
        // /////////////////////////////////////////////////
        
        [Fact]
        public void Moving_U_From_1_Returns_1() 
        {
            var d = new Day02();
            d.CurrentPosition = "1";
            d.Move(Day02.Direction.Up);
            Assert.Equal("1", d.CurrentPosition);
        }

        [Fact]
        public void Moving_D_From_1_Returns_4() 
        {
            var d = new Day02();
            d.CurrentPosition = "1";
            d.Move(Day02.Direction.Down);
            Assert.Equal("4", d.CurrentPosition);
        }

        [Fact]
        public void Moving_L_From_1_Returns_1() 
        {
            var d = new Day02();
            d.CurrentPosition = "1";
            d.Move(Day02.Direction.Left);
            Assert.Equal("1", d.CurrentPosition);
        }

        [Fact]
        public void Moving_R_From_1_Returns_2() 
        {
            var d = new Day02();
            d.CurrentPosition = "1";
            d.Move(Day02.Direction.Right);
            Assert.Equal("2", d.CurrentPosition);
        }

        // /////////////////////////////////////////////////
        // MOVING FROM 2
        // /////////////////////////////////////////////////
        
        [Fact]
        public void Moving_U_From_2_Returns_2() 
        {
            var d = new Day02();
            d.CurrentPosition = "2";
            d.Move(Day02.Direction.Up);
            Assert.Equal("2", d.CurrentPosition);
        }

        [Fact]
        public void Moving_D_From_2_Returns_5() 
        {
            var d = new Day02();
            d.CurrentPosition = "2";
            d.Move(Day02.Direction.Down);
            Assert.Equal("5", d.CurrentPosition);
        }

        [Fact]
        public void Moving_L_From_2_Returns_1() 
        {
            var d = new Day02();
            d.CurrentPosition = "2";
            d.Move(Day02.Direction.Left);
            Assert.Equal("1", d.CurrentPosition);
        }

        [Fact]
        public void Moving_R_From_1_Returns_3() 
        {
            var d = new Day02();
            d.CurrentPosition = "2";
            d.Move(Day02.Direction.Right);
            Assert.Equal("3", d.CurrentPosition);
        }

        // /////////////////////////////////////////////////
        // MOVING FROM 3
        // /////////////////////////////////////////////////
        
        [Fact]
        public void Moving_U_From_3_Returns_3() 
        {
            var d = new Day02();
            d.CurrentPosition = "3";
            d.Move(Day02.Direction.Up);
            Assert.Equal("3", d.CurrentPosition);
        }

        [Fact]
        public void Moving_D_From_3_Returns_6() 
        {
            var d = new Day02();
            d.CurrentPosition = "3";
            d.Move(Day02.Direction.Down);
            Assert.Equal("6", d.CurrentPosition);
        }

        [Fact]
        public void Moving_L_From_3_Returns_1() 
        {
            var d = new Day02();
            d.CurrentPosition = "3";
            d.Move(Day02.Direction.Left);
            Assert.Equal("2", d.CurrentPosition);
        }

        [Fact]
        public void Moving_R_From_3_Returns_3() 
        {
            var d = new Day02();
            d.CurrentPosition = "3";
            d.Move(Day02.Direction.Right);
            Assert.Equal("3", d.CurrentPosition);
        }

        // /////////////////////////////////////////////////
        // MOVING FROM 4
        // /////////////////////////////////////////////////
        
        [Fact]
        public void Moving_U_From_4_Returns_1() 
        {
            var d = new Day02();
            d.CurrentPosition = "4";
            d.Move(Day02.Direction.Up);
            Assert.Equal("1", d.CurrentPosition);
        }

        [Fact]
        public void Moving_D_From_4_Returns_7() 
        {
            var d = new Day02();
            d.CurrentPosition = "4";
            d.Move(Day02.Direction.Down);
            Assert.Equal("7", d.CurrentPosition);
        }

        [Fact]
        public void Moving_L_From_4_Returns_4() 
        {
            var d = new Day02();
            d.CurrentPosition = "4";
            d.Move(Day02.Direction.Left);
            Assert.Equal("4", d.CurrentPosition);
        }

        [Fact]
        public void Moving_R_From_4_Returns_5() 
        {
            var d = new Day02();
            d.CurrentPosition = "4";
            d.Move(Day02.Direction.Right);
            Assert.Equal("5", d.CurrentPosition);
        }

        // /////////////////////////////////////////////////
        // MOVING FROM 5
        // /////////////////////////////////////////////////
        [Fact]
        public void Moving_L_From_5_Returns_4() 
        {
            var d = new Day02();
            d.Move(Day02.Direction.Left);
            Assert.Equal("4", d.CurrentPosition);
        }

        [Fact]
        public void Moving_R_From_5_Returns_6() 
        {
            var d = new Day02();
            d.Move(Day02.Direction.Right);
            Assert.Equal("6", d.CurrentPosition);
        }

        [Fact]
        public void Moving_U_From_5_Returns_2() 
        {
            var d = new Day02();
            d.Move(Day02.Direction.Up);
            Assert.Equal("2", d.CurrentPosition);
        }

        [Fact]
        public void Moving_D_From_5_Returns_8() 
        {
            var d = new Day02();
            d.Move(Day02.Direction.Down);
            Assert.Equal("8", d.CurrentPosition);
        }

        // /////////////////////////////////////////////////
        // MOVING FROM 6
        // /////////////////////////////////////////////////
        [Fact]
        public void Moving_L_From_6_Returns_5() 
        {
            var d = new Day02();
            d.CurrentPosition = "6";
            d.Move(Day02.Direction.Left);
            Assert.Equal("5", d.CurrentPosition);
        }

        [Fact]
        public void Moving_R_From_6_Returns_6() 
        {
            var d = new Day02();
            d.CurrentPosition = "6";
            d.Move(Day02.Direction.Right);
            Assert.Equal("6", d.CurrentPosition);
        }

        [Fact]
        public void Moving_U_From_6_Returns_3() 
        {
            var d = new Day02();
            d.CurrentPosition = "6";
            d.Move(Day02.Direction.Up);
            Assert.Equal("3", d.CurrentPosition);
        }

        [Fact]
        public void Moving_D_From_6_Returns_9() 
        {
            var d = new Day02();
            d.CurrentPosition = "6";
            d.Move(Day02.Direction.Down);
            Assert.Equal("9", d.CurrentPosition);
        }

        // /////////////////////////////////////////////////
        // MOVING FROM 7
        // /////////////////////////////////////////////////
        [Fact]
        public void Moving_L_From_7_Returns_7() 
        {
            var d = new Day02();
            d.CurrentPosition = "7";
            d.Move(Day02.Direction.Left);
            Assert.Equal("7", d.CurrentPosition);
        }

        [Fact]
        public void Moving_R_From_7_Returns_8() 
        {
            var d = new Day02();
            d.CurrentPosition = "7";
            d.Move(Day02.Direction.Right);
            Assert.Equal("8", d.CurrentPosition);
        }

        [Fact]
        public void Moving_U_From_7_Returns_4() 
        {
            var d = new Day02();
            d.CurrentPosition = "7";
            d.Move(Day02.Direction.Up);
            Assert.Equal("4", d.CurrentPosition);
        }

        [Fact]
        public void Moving_D_From_7_Returns_7() 
        {
            var d = new Day02();
            d.CurrentPosition = "7";
            d.Move(Day02.Direction.Down);
            Assert.Equal("7", d.CurrentPosition);
        }

        // /////////////////////////////////////////////////
        // MOVING FROM 8
        // /////////////////////////////////////////////////
        [Fact]
        public void Moving_L_From_8_Returns_7() 
        {
            var d = new Day02();
            d.CurrentPosition = "8";
            d.Move(Day02.Direction.Left);
            Assert.Equal("7", d.CurrentPosition);
        }

        [Fact]
        public void Moving_R_From_8_Returns_9() 
        {
            var d = new Day02();
            d.CurrentPosition = "8";
            d.Move(Day02.Direction.Right);
            Assert.Equal("9", d.CurrentPosition);
        }

        [Fact]
        public void Moving_U_From_8_Returns_5() 
        {
            var d = new Day02();
            d.CurrentPosition = "8";
            d.Move(Day02.Direction.Up);
            Assert.Equal("5", d.CurrentPosition);
        }

        [Fact]
        public void Moving_D_From_8_Returns_8() 
        {
            var d = new Day02();
            d.CurrentPosition = "8";
            d.Move(Day02.Direction.Down);
            Assert.Equal("8", d.CurrentPosition);
        }

        // /////////////////////////////////////////////////
        // MOVING FROM 9
        // /////////////////////////////////////////////////
        [Fact]
        public void Moving_L_From_9_Returns_8() 
        {
            var d = new Day02();
            d.CurrentPosition = "9";
            d.Move(Day02.Direction.Left);
            Assert.Equal("8", d.CurrentPosition);
        }

        [Fact]
        public void Moving_R_From_9_Returns_9() 
        {
            var d = new Day02();
            d.CurrentPosition = "9";
            d.Move(Day02.Direction.Right);
            Assert.Equal("9", d.CurrentPosition);
        }

        [Fact]
        public void Moving_U_From_9_Returns_6() 
        {
            var d = new Day02();
            d.CurrentPosition = "9";
            d.Move(Day02.Direction.Up);
            Assert.Equal("6", d.CurrentPosition);
        }

        [Fact]
        public void Moving_D_From_9_Returns_9() 
        {
            var d = new Day02();
            d.CurrentPosition = "9";
            d.Move(Day02.Direction.Down);
            Assert.Equal("9", d.CurrentPosition);
        }

        // /////////////////////////////////////////////////
        // Parse Instructions
        // /////////////////////////////////////////////////
        [Fact]
        public void Moving_From_Instructions_With_Defualt_KeypadMap_ULLRRDDDLURDLUUUD_Returns_Code_1985() 
        {
            var expectedResult = "1985";
            var d = new Day02();
            d.Instructions = "ULL\nRRDDD\nLURDL\nUUUUD";
            d.ParseInstructions();
            Assert.Equal(expectedResult, d.Code);
        }

        [Fact]
        public void Moving_From_Instructions_With_KeypadMap_13_ULLRRDDDLURDLUUUD_Returns_Code_5DB3() 
        {
            var expectedResult = "5DB3";
            var d = new Day02();
            d.Instructions = "ULL\nRRDDD\nLURDL\nUUUUD";
            d.ParseInstructions(d.Move_13);
            Assert.Equal(expectedResult, d.Code);
        }

    }
}
