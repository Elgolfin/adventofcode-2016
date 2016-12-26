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

Borrowed the solution from https://github.com/leveneg/2016AdventOfCode

I know...

##Day12 Solution

[Source Code][Day12SC] | 
[Unit Tests][Day12UT]

I've used the same logic as last year (See https://github.com/Elgolfin/adventofcode-2015#day23-solution) and I've made some minor changes to the 'Instruction' class.

It now executes an instruction taking into account the whole collection of computer registers.
It also always use two parameters (x and y) during the execution (could be either a register or a value depending of the instruction type).

##Day13 Solution

[Source Code][Day13SC] | 
[Unit Tests][Day13UT]

I've used a breadth-first search algorithm to solve the part I of the puzzle (See https://www.youtube.com/watch?v=E_V71Ejz3f4).

##Day14 Solution

[Source Code][Day14SC] | 
[Unit Tests][Day14UT]

Precompiling the hashes in a dictionary improves the performance by a factor of 5 (i.e. for the Part I of the puzzle, it takes 3 seconds to get the right answer instead of 15 seconds, approximately).

##Day15 Solution

[Source Code][Day15SC] | 
[Unit Tests][Day15UT]

##Day16 Solution

[Source Code][Day16SC] | 
[Unit Tests][Day16UT]

##Day17 Solution

I've used the same kind of logic I've used for the Day 13 Puzzle (a breadth-first search algorithm).

Part II was quite easy. I've just to not break the loop to find the last path to the exit
(and therefore all the paths who lead to the exit are also found by the program).
The last path being also the longest.

[Source Code][Day17SC] | 
[Unit Tests][Day17UT]

##Day18 Solution

[Source Code][Day18SC] | 
[Unit Tests][Day18UT]

##Day19 Solution

[Source Code][Day19SC] | 
[Unit Tests][Day19UT]

I've made the solution of the Part I in less than 15 minutes (including unit tests) by using a queue.

Three hours later, I've got stuck in Part II. :-) My methods (brute force) were way too slow to get the answer.
So, after some research, I've borrowed a solution from the internet (who uses pure mathematics).

##Day20 Solution

[Source Code][Day20SC] | 
[Unit Tests][Day20UT]

## Day21 Solution

[Source Code][Day21SC] | 
[Unit Tests][Day21UT]

I should refactor many methods as they share almost the same logic. Unit tests are well done and will secure this refactoring.
Each instruction should be an object with a method Execute to run it.

## Day22 Solution

[Source Code][Day22SC] | 
[Unit Tests][Day22UT]

## Day23 Solution

[Source Code][Day23SC] | 
[Unit Tests][Day23UT]

I've reused the logic of the Day 12 Puzzle and make the following changes :
  - Create a new Cmputerv2 class who inherits the original Computer Class. Therefore I've changed the logic of the Run method to accomadate the new TGL instruction.
  - Add a new instruction and its related behavior
  - Update many original instructions to fix some issues (i.e. now the computer supports instruction with negative argument; the unit tests to validate the changes are not included yet)

## Day24 Solution

[Source Code][Day24SC] | 
[Unit Tests][Day24UT]

I've reused some logic of the Day 13 puzzle and Day 22 puzzle. The distance between each destination points are pre-calculated in a lazy way (See here https://en.wikipedia.org/wiki/Lazy_loading).

For the second part, I've just added a final destination corresponding to the starting point.

## Day25 Solution

I've figured out the solution by hand. 2730 (101010101010 in binary) - 2555 (7 * 365) = 175

See the thread and all the excellent explanations on Reddit: https://www.reddit.com/r/adventofcode/comments/5k6yfu/2016_day_25_solutions/


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
[Day10SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/src/AdventOfCode2016/Day10.cs
[Day11SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/src/AdventOfCode2016/Day11.cs
[Day12SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/src/AdventOfCode2016/Day12.cs
[Day13SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/src/AdventOfCode2016/Day13.cs
[Day14SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/src/AdventOfCode2016/Day14.cs
[Day15SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/src/AdventOfCode2016/Day15.cs
[Day16SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/src/AdventOfCode2016/Day16.cs
[Day17SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/src/AdventOfCode2016/Day17.cs
[Day18SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/src/AdventOfCode2016/Day18.cs
[Day19SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/src/AdventOfCode2016/Day19.cs
[Day20SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/src/AdventOfCode2016/Day20.cs
[Day21SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/src/AdventOfCode2016/Day21.cs
[Day22SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/src/AdventOfCode2016/Day22.cs
[Day23SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/src/AdventOfCode2016/Day23.cs
[Day24SC]:https://github.com/Elgolfin/adventofcode-2016/blob/master/src/AdventOfCode2016/Day24.cs


[Day01UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day01UnitTests.cs
[Day02UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day02UnitTests.cs
[Day03UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day03UnitTests.cs
[Day04UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day04UnitTests.cs
[Day05UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day05UnitTests.cs
[Day06UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day06UnitTests.cs
[Day07UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day07UnitTests.cs
[Day08UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day08UnitTests.cs
[Day09UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day09UnitTests.cs
[Day10UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day10UnitTests.cs
[Day11UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day11UnitTests.cs
[Day12UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day12UnitTests.cs
[Day13UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day13UnitTests.cs
[Day14UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day14UnitTests.cs
[Day15UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day15UnitTests.cs
[Day16UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day16UnitTests.cs
[Day17UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day17UnitTests.cs
[Day18UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day18UnitTests.cs
[Day19UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day19UnitTests.cs
[Day20UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day20UnitTests.cs
[Day21UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day21UnitTests.cs
[Day22UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day22UnitTests.cs
[Day23UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day23UnitTests.cs
[Day24UT]:https://github.com/Elgolfin/adventofcode-2016/blob/master/test/Day24UnitTests.cs