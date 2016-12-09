[![Build status](https://ci.appveyor.com/api/projects/status/owqenrdfs8pd1hwe?svg=true)](https://ci.appveyor.com/project/Elgolfin/adventofcode-2016)

# Advent of Code 2016

Online Resources:
- [Advent of Code 2016 Website][l1]
- [Nice online Regex editor][regex101]

## Development Instructions
### Installation
- git clone https://github.com/Elgolfin/adventofcode-2016.git
- cd adventofcode-2016 
- dotnet restore

### Run the console app
- dotnet run src/console

### Execute the unit tests suite
- dotnet test test

## Day01 Solution

[Source Code][Day01SC] | 
[Unit Tests][Day01UT]

## Day02 Solution

[Source Code][Day02SC] | 
[Unit Tests][Day02UT]

## Day03 Solution

[Source Code][Day03SC] | 
[Unit Tests][Day03UT]

## Day04 Solution

[Source Code][Day04SC] | 
[Unit Tests][Day04UT]

## Day05 Solution

[Source Code][Day05SC] | 
[Unit Tests][Day05UT]

## Day06 Solution

[Source Code][Day06SC] | 
[Unit Tests][Day06UT]

## Day07 Solution

[Source Code][Day07SC] | 
[Unit Tests][Day07UT]

## Day08 Solution

[Source Code][Day08SC] | 
[Unit Tests][Day08UT]

Each 'Command' object should have its own 'Run' logic. Currently, the 'Command' class owns three different kin of execution (Rect, Rotate Row and Rotate Column). Doing this way, when we need to add a command, we will just create a new object without modifying the existing one(s).

##Day09 Solution

[Source Code][Day09SC] | 
[Unit Tests][Day09UT]

Please see the comments above the method 'Decompress_v21' to get the explanation of how to calculate the number of characters who composed the uncompressed string without getting an OutOfMemoryException.

##Day10 Solution

[Source Code][Day10SC] | 
[Unit Tests][Day10UT]

##Day11 Solution

[Source Code][Day11SC] | 
[Unit Tests][Day11UT]

##Day12 Solution

[Source Code][Day12SC] | 
[Unit Tests][Day12UT]

##Day14 Solution

[Source Code][Day14SC] | 
[Unit Tests][Day14UT]

##Day20 Solution

[Source Code][Day20SC] | 
[Unit Tests][Day20UT]

## Day21 Solution

[Source Code][Day21SC] | 
[Unit Tests][Day21UT]

## Day23 Solution

[Source Code][Day23SC] | 
[Unit Tests][Day23UT]

## Day25 Solution

[Source Code][Day25SC] | 
[Unit Tests][Day25UT]


[l1]:http://adventofcode.com/
[l2]:https://msdn.microsoft.com/en-CA/library/bb383977.aspx
[regex101]:https://regex101.com/

[Day01SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/src/AdventOfCode2016/Day01.cs
[Day02SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/src/AdventOfCode2016/Day02.cs
[Day03SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/src/AdventOfCode2016/Day03.cs
[Day04SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/src/AdventOfCode2016/Day04.cs
[Day05SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/src/AdventOfCode2016/Day05.cs
[Day06SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/src/AdventOfCode2016/Day06.cs
[Day07SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/src/AdventOfCode2016/Day07.cs
[Day08SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/src/AdventOfCode2016/Day08.cs
[Day09SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/src/AdventOfCode2016/Day09.cs
[Day10SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/Day10.cs
[Day11SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/Day11.cs
[Day12SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/Day12.cs
[Day14SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/Day14.cs

[Day20SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/Day20.cs
[Day21SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/Day21.cs
[Day23SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/Day23.cs
[Day25SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/Day25.cs



[Day01UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day01UnitTests.cs
[Day02UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day02UnitTests.cs
[Day03UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day03UnitTests.cs
[Day04UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day04UnitTests.cs
[Day05UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day05UnitTests.cs
[Day06UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day06UnitTests.cs
[Day07UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day07UnitTests.cs
[Day08UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day08UnitTests.cs
[Day09UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day09UnitTests.cs

[Day10UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/AdventOfCode2015UnitTests/Day10_UnitTest.cs
[Day11UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/AdventOfCode2015UnitTests/Day11_UnitTest.cs
[Day12UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/AdventOfCode2015UnitTests/Day12_UnitTest.cs
[Day14UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/AdventOfCode2015UnitTests/Day14_UnitTest.cs

[Day20UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/AdventOfCode2015UnitTests/Day20_UnitTest.cs
[Day21UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/AdventOfCode2015UnitTests/Day21_UnitTest.cs
[Day23UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/AdventOfCode2015UnitTests/Day23_UnitTest.cs
[Day25UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/AdventOfCode2015UnitTests/Day23_UnitTest.cs