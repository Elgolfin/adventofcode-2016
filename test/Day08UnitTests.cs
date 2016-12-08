using System;
using Xunit;
using AdventOfCode1016;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode1016Tests
{
    public class Day08UnitTests
    {
        /*
        [Theory]
        [InlineData("abba")]
        [InlineData("abba[mnop]qrst")] // abba[mnop]qrst supports TLS (abba outside square brackets).
        [InlineData("ioxxoj[asdfgh]zxcvbn")] // ioxxoj[asdfgh]zxcvbn supports TLS (oxxo is outside square brackets, even though it's within a larger string).
        [InlineData("rxpusykufgqujfe[rypwoorxdemxffui]cvvcufcqmxoxcphp[witynplrfvquduiot]vcysdcsowcxhphp[gctucefriclxaonpwe]jdprpdvpeumrhokrcjt")]
        public void Has_ABBA_Input_Should_Return_True(string input) 
        {
            Assert.Equal(true, Day07.HasABBA(input));
        }
        */

        [Fact]
        public void Command_rect_3x2_Should_Return_Name_Rect_x_3_y_2() 
        {
            var input = @"rect 3x2";
            var c = new Command(input);
            Assert.Equal(Command.Type.Rect, c.Name);
            Assert.Equal(3, c.X);
            Assert.Equal(2, c.Y);
            Assert.Equal(0, c.By);
        }

        [Fact]
        public void Command_rotate_column_x_1_by_1_Should_Return_Name_Rotate_Column_x_1_by_1() 
        {
            var input = @"rotate column x=1 by 1";
            var c = new Command(input);
            Assert.Equal(Command.Type.Rotate_Column, c.Name);
            Assert.Equal(1, c.X);
            Assert.Equal(0, c.Y);
            Assert.Equal(1, c.By);
        }

        [Fact]
        public void Command_rotate_row_y_0_by_4_Should_Return_Name_Rotate_Row_y_0_by_4() 
        {
            var input = @"rotate row y=0 by 4";
            var c = new Command(input);
            Assert.Equal(Command.Type.Rotate_Row, c.Name);
            Assert.Equal(0, c.X);
            Assert.Equal(0, c.Y);
            Assert.Equal(4, c.By);
        }

        [Fact]
        public void Adding_4_Commands_Should_Return_A_List_Of_4_Commands() 
        {
            var input = @"rect 3x2
rotate column x=1 by 1
rotate row y=0 by 4
rotate column x=1 by 1
";
            var d = new Day08(input);
            Assert.Equal(4, d.Commands.Count);
        }

        [Fact]
        public void Initialize_A_Screen_Should_Display_Dots_Only() 
        {
            var input = @"rect 3x2";
            var expected = new char[3, 7] {
                {'.', '.', '.', '.', '.', '.', '.'},
                {'.', '.', '.', '.', '.', '.', '.'},
                {'.', '.', '.', '.', '.', '.', '.'}
            };
            var d = new Day08(input, 3, 7);
            Assert.Equal(expected, d.Screen);
        }

        [Fact]
        public void Executing_Rect_3x2_Should_Display_The_Right_Pixels_On_The_Screen() 
        {
            var input = @"rect 3x2";
            var expected = new char[3, 7] {
                {'#', '#', '#', '.', '.', '.', '.'},
                {'#', '#', '#', '.', '.', '.', '.'},
                {'.', '.', '.', '.', '.', '.', '.'}
            };
            var d = new Day08(input, 3, 7);
            d.Run();
            Assert.Equal(expected, d.Screen);
        }

        [Fact]
        public void Executing_Rect_3x2_Rotate_Column_x1_by1_Should_Display_The_Right_Pixels_On_The_Screen() 
        {
            var input = @"rect 3x2
            rotate column x=1 by 1";
            var expected = new char[3, 7] {
                {'#', '.', '#', '.', '.', '.', '.'},
                {'#', '#', '#', '.', '.', '.', '.'},
                {'.', '#', '.', '.', '.', '.', '.'}
            };
            var d = new Day08(input, 3, 7);
            d.Run();
            Assert.Equal(expected, d.Screen);
        }

        [Fact]
        public void Executing_Rect_3x2_Rotate_Column_x1_by1_Rotate_Row_y0_by4_Should_Display_The_Right_Pixels_On_The_Screen() 
        {
            var input = @"rect 3x2
            rotate column x=1 by 1
            rotate row y=0 by 4";
            var expected = new char[3, 7] {
                {'.', '.', '.', '.', '#', '.', '#'},
                {'#', '#', '#', '.', '.', '.', '.'},
                {'.', '#', '.', '.', '.', '.', '.'}
            };
            var d = new Day08(input, 3, 7);
            d.Run();
            Assert.Equal(expected, d.Screen);
        }

        [Fact]
        public void Executing_Rect_3x2_Rotate_Column_x1_by1_Rotate_Row_y0_by4_Should_Return_6_Lit_Pixels() 
        {
            var input = @"rect 3x2
            rotate column x=1 by 1
            rotate row y=0 by 4";
            var d = new Day08(input, 3, 7);
            d.Run();
            Assert.Equal(6, d.NumberOfLitPixels());
        }

    }
}
