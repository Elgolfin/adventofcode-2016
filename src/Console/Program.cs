using System;
using AdventOfCode1016;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input;
            
            // /////////////////////////////////////////////////
            // Day 21
            // /////////////////////////////////////////////////
            input = Day21Input.Data;
            var d21 = new Day21(input);
            var scrambledPassword = d21.ScramblePassword("abcdefgh");
            Console.WriteLine($"Day 21");
            Console.WriteLine($"------");
            Console.WriteLine($"The result of scrambling abcdefgh is {scrambledPassword}");
            var unscrambledPassword = d21.UnScramblePassword("fbgdceah");
            Console.WriteLine($"The un-scrambled version of the scrambled password fbgdceah is {unscrambledPassword}");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");

            // /////////////////////////////////////////////////
            // Day 20
            // /////////////////////////////////////////////////
            input = Day20Input.Data;
            var d20 = new Day20(input);
            Console.WriteLine($"Day 20");
            Console.WriteLine($"------");
            Console.WriteLine($"The lowest-valued IP that is not blocked is {d20.GetLowestValuedOFNotBlockedIPs()}");
            Console.WriteLine($"{d20.GetAllAllowedIPs()} IPs are allowed by the blacklist");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");

            // /////////////////////////////////////////////////
            // Day 19
            // /////////////////////////////////////////////////
            var d19 = new Day19(Day19Input.Data);
            //var d19 = new Day19(5);
            var numElf = d19.GetElfWithAllPresents();
            Console.WriteLine($"Day 19");
            Console.WriteLine($"------");
            d19 = new Day19(Day19Input.Data);
            Console.WriteLine($"Elf {numElf} gets all the presents");
            numElf = d19.GetFormulaCrossPosition();
            Console.WriteLine($"Elf {numElf} now gets all the presents");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");

            // /////////////////////////////////////////////////
            // Day 18
            // /////////////////////////////////////////////////
            input = Day18Input.Data;
            var d18 = new Day18(input);
            Console.WriteLine($"Day 18");
            Console.WriteLine($"------");
            var safeTiles = d18.GetNumberOfSafeTiles(40);
            Console.WriteLine($"There are {safeTiles} safe tiles within 40 rows");
            safeTiles = d18.GetNumberOfSafeTiles(400000);
            Console.WriteLine($"There are {safeTiles} safe tiles within 400,000 rows");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");

            // /////////////////////////////////////////////////
            // Day 17
            // /////////////////////////////////////////////////
            input = Day17Input.Data;
            var d17 = new Day17();
            Console.WriteLine($"Day 17");
            var pathToExit =  d17.FindPathToExit();
            Console.WriteLine($"------");
            Console.WriteLine($"The shortest path to exit is {pathToExit}");
            var length =  d17.FindLongestPathToExit();
            Console.WriteLine($"The longest path to exit takes {length} steps");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");

            // /////////////////////////////////////////////////
            // Day 16
            // /////////////////////////////////////////////////
            input = Day16Input.Data;
            var d16 = new Day16();
            var checksum = Day16.FillDisk("10001001100000001", 272);
            Console.WriteLine($"Day 16");
            Console.WriteLine($"------");
            Console.WriteLine($"The correct checksum is {checksum}");
            checksum = Day16.FillDisk("10001001100000001", 35651584);
            Console.WriteLine($"The correct checksum is {checksum}");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");

            // /////////////////////////////////////////////////
            // Day 15
            // /////////////////////////////////////////////////
            input = Day14Input.Data;
            var d15 = new Day15();
            Console.WriteLine($"Day 15");
            Console.WriteLine($"------");
            Console.WriteLine($"The first time the button can be press to get a capsule is {d15.PushButtonToFallThrough()}");
            d15 = new Day15();
            d15.AddDisc(new Disc(11, 0));
            Console.WriteLine($"The first time the button can be press to get another capsule is {d15.PushButtonToFallThrough()}");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");

            // /////////////////////////////////////////////////
            // Day 14
            // /////////////////////////////////////////////////
            input = Day14Input.Data;
            var d14 = new Day14();
            Console.WriteLine($"Day 14");
            Console.WriteLine($"------");
            Console.WriteLine($"The index producing the 64th one-time pad key is {d14.ReturnNthValidKey(64)}");
            d14 = new Day14(2016);
            Console.WriteLine($"The index producing the 64th one-time pad key and using 2016 extra MD5 calls of key stretching is {d14.ReturnNthValidKey(64)}");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");

            // /////////////////////////////////////////////////
            // Day 13
            // /////////////////////////////////////////////////
            input = Day13Input.Data;
            var d13 = new Day13(1, 1, 100, 100, 1352);
            var key = "31,39";
            Console.WriteLine($"Day 13");
            Console.WriteLine($"------");
            Console.WriteLine($"The fewest number of steps required to reach 31,39 is {d13.FindDistanceToLocation(key)}");
            d13 = new Day13(1, 1, 10000, 10000, 1352);
            Console.WriteLine($"{d13.CountLocationWithinNSteps(50)} locations (distinct x,y coordinates, including the starting location) can be reached in at most 50 steps");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");

            // /////////////////////////////////////////////////
            // Day 12
            // /////////////////////////////////////////////////
            input = Day12Input.Data;
            var d12 = new Day12(input);
            var c = new Computer();
            c.LoadProgramFromString(input);
            c.Run();
            Console.WriteLine($"Day 12");
            Console.WriteLine($"------");
            Console.WriteLine($"After executing the assembunny code, the value left in register a is {c.RegisterA}");
            c.Reset(0, 0, 1, 0);
            c.Run();
            Console.WriteLine($"After executing the assembunny code (by initializing register c to be 1), the value left in register a is {c.RegisterA}");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");

            // /////////////////////////////////////////////////
            // Day 11
            // /////////////////////////////////////////////////
            input = Day11Input.Data;
            var d11 = new Day11(input);
            Console.WriteLine($"Day 11");
            Console.WriteLine($"------");
            Console.WriteLine($"The minimum number of steps required to bring all of the objects to the fourth floor is 47");
            Console.WriteLine($"The minimum number of steps required to bring all of the objects to the fourth floor is 71");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");

            // /////////////////////////////////////////////////
            // Day 10
            // /////////////////////////////////////////////////
            input = Day10Input.Data;
            var d10 = new Day10(input, 17, 61);
            d10.InitializeBots();
            d10.RunInstructions();
            Console.WriteLine($"Day 10");
            Console.WriteLine($"------");
            Console.WriteLine($"The number of the bot that is responsible for comparing value-61 microchips with value-17 microchips is {d10.GetBotResponsibleToCompare().Id}");
            Console.WriteLine($"The result of multiply together the values of one chip in each of outputs 0, 1, and 2 is {d10.Outputs[0].Chip * d10.Outputs[1].Chip * d10.Outputs[2].Chip}");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");

            // /////////////////////////////////////////////////
            // Day 09
            // /////////////////////////////////////////////////
            input = Day09Input.Data;
            var d09 = new Day09(input);
            Console.WriteLine($"Day 09");
            Console.WriteLine($"------");
            Console.WriteLine($"The decompressed length of the file is {d09.DecompressedInput.Length}");
            Console.WriteLine($"The decompressed (v2.1) length of the file is {d09.DecompressedInput_v2_Length}");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");

            // /////////////////////////////////////////////////
            // Day 08
            // /////////////////////////////////////////////////
            input = Day08Input.Data;
            var d08 = new Day08(input);
            d08.Run();
            Console.WriteLine($"Day 08");
            Console.WriteLine($"------");
            Console.WriteLine($"There are {d08.NumberOfLitPixels()} lit pixels");
            Console.WriteLine($"");
            Console.WriteLine(d08.ToString());
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");
            

            // /////////////////////////////////////////////////
            // Day 07
            // /////////////////////////////////////////////////
            input = Day07Input.Data;
            var d07 = new Day07(input);
            Console.WriteLine($"Day 07");
            Console.WriteLine($"------");
            Console.WriteLine($"There are {d07.NumberOfIpsSupportingTLS} IPs supporting TLS");
            Console.WriteLine($"There are {d07.NumberOfIpsSupportingSSL} IPs supporting SSL");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");

            // /////////////////////////////////////////////////
            // Day 06
            // /////////////////////////////////////////////////
            input = Day06Input.Data;
            var d06 = new Day06(input);
            d06.GetMessage();
            Console.WriteLine($"Day 06");
            Console.WriteLine($"------");
            Console.WriteLine($"The error-corrected version of the message being sent is {d06.Message}");
            d06.GetMessage(Day06.OrderBy.Asc);
            Console.WriteLine($"The error-corrected version of the message being sent is {d06.Message}");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");

            // /////////////////////////////////////////////////
            // Day 05
            // /////////////////////////////////////////////////
            input = "cxdnnyjw";
            //var password = Day05.FindPassword(input); // Uncomment to run the computing (quite slow)
            var password = "f77a0e6e";
            Console.WriteLine($"Day 05");
            Console.WriteLine($"------");
            Console.WriteLine($"Given the actual Door ID <{input}>, the password is {password}");
            //password = Day05.FindMoreSophisticatedPassword(input); // Uncomment to run the computing (quite slower than the previous one)
            password = "999828ec";
            Console.WriteLine($"Given the actual Door ID <{input}>, the more sophisticated password is {password}");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");


            // /////////////////////////////////////////////////
            // Day 04
            // /////////////////////////////////////////////////
            
            input = Day04Input.Data;
            var d04 = new Day04(input);
            Console.WriteLine($"Day 04");
            Console.WriteLine($"------");
            Console.WriteLine($"Of the real rooms from the input list, the sum of their sector IDs is {d04.SectorIdSum}");
            foreach (var r in d04.Rooms) {
              if (r.Name == "northpole object storage") {
                Console.WriteLine($"The sector ID of the room where North Pole objects are stored is {r.SectorId}");
              }
            }
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");

            // /////////////////////////////////////////////////
            // Day 03
            // /////////////////////////////////////////////////
        
            input = Day03Input.Data;
            var d03 = new Day03(input);
            d03.ParseTriangles();
            Console.WriteLine($"Day 03");
            Console.WriteLine($"------");
            Console.WriteLine($"There are {d03.NumberOfPossibleTriangles} possible triangles");
            d03 = new Day03(input, true);
            d03.ParseTriangles();
            Console.WriteLine($"There are {d03.NumberOfPossibleTriangles} possible triangles");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");


            // /////////////////////////////////////////////////
            // Day 02
            // /////////////////////////////////////////////////
        
            input = Day02Input.Data;
            var d02 = new Day02();
            d02.Instructions = input;
            d02.ParseInstructions();
            Console.WriteLine($"Day 02");
            Console.WriteLine($"------");
            Console.WriteLine($"The code is: {d02.Code}");d02 = new Day02();
            d02.Instructions = input;
            d02.ParseInstructions(d02.Move_13);
            Console.WriteLine($"The code is: {d02.Code}");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");

            // /////////////////////////////////////////////////
            // Day 01
            // /////////////////////////////////////////////////
        
            input = Day01Input.Data;
            var d01 = new Day01(input);
            d01.MoveAlongThePath();
            Console.WriteLine($"Day 01");
            Console.WriteLine($"------");
            Console.WriteLine($"You are {d01.GetBlocksAwayFromStart()} blocks away");
            Console.WriteLine($"The first location visited twice is {d01.FirstVisitedLocationTwice} blocks away");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"");

        }
    }
}
