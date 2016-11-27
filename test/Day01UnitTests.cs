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
        public void Test_Should_Return_Hiya_Foo() 
        {
            var p = new Day01();
            Assert.Equal("Hiya Foo!", Day01.Test());
        }

        
        
    }
}
