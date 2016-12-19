using System;
using Xunit;
using AdventOfCode1016;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode1016Tests
{
    public class Day19UnitTests
    {
        [Fact]
        public void Circle_Of_5_Elves_Should_Return_Elf_3_Who_Got_All_Presents() 
        {
            var d19 = new Day19(5);
            Assert.Equal(3, d19.GetElfWithAllPresents());
        }
        
        [Fact]
        public void Circle_Of_5_Elves_Across_Should_Return_Elf_2_Who_Got_All_Presents() 
        {
            var d19 = new Day19(5);
            Assert.Equal(2, d19.GetElfWithAllPresents_Across());
        }

        
        [Fact]
        public void Circle_Of_5_Elves_AcrossD_Should_Return_Elf_2_Who_Got_All_Presents() 
        {
            var d19 = new Day19(5);
            Assert.Equal(2, d19.GetElfWithAllPresents_AcrossD());
        }
        

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 4)]
        [InlineData(4, 5)]
        [InlineData(5, 1)]
        [InlineData(6, 1)]
        [InlineData(0, 1)]
        public void Increment_X_Should_Return_Y (int id, int expectedResult){
            var d19 = new Day19(5);
            Assert.Equal(expectedResult, d19.IncrementId(id));
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 4)]
        [InlineData(3, 4)]
        [InlineData(4, 5)]
        [InlineData(5, 1)]
        [InlineData(6, 1)]
        [InlineData(0, 1)]
        public void Increment_X_List_Of_4_Should_Return_Y (int id, int expectedResult){
            var d19 = new Day19(5);
            d19.ElvesD.Remove(3);
            d19.RemovedElves.Add(3);
            Assert.Equal(expectedResult, d19.IncrementId(id));
        }

    }
}
