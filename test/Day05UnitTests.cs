using System;
using Xunit;
using AdventOfCode1016;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode1016Tests
{
    public class Day05UnitTests
    {
        
        [Fact]
        public void Find_Password_With_Doot_Id_abc_Should_Return_18f47a30() 
        {
            var id = "abc";
            Assert.Equal("18f47a30", Day05.FindPassword(id));
        }

        /* Put the static method FindChar as public in Day05.cs
        [Fact]
        public void Find_First_Five_Zeros_Hash_With_Id_abc_Should_Return_Sixth_Char_1() 
        {
            var id = "abc";
            var index = 0;
            var result = ' ';
            var num = 1;
            var i = 0;
            foreach (var c in Day05.FindChar(id)) {
                result = c;
                i++;
                if (i == num) { break; }
            }
            Assert.Equal('1', result);
        }

        [Fact]
        public void Find_Second_Five_Zeros_Hash_With_Id_abc_Should_Return_Sixth_Char_8() 
        {
            var id = "abc";
            var index = 0;
            var result = ' ';
            var num = 2;
            var i = 0;
            foreach (var c in Day05.FindChar(id)) {
                result = c;
                i++;
                if (i == num) { break; }
            }
            Assert.Equal('8', result);
        }
        */

    }
}
