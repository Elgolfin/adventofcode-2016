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
            // Day 10
            // /////////////////////////////////////////////////
            input = Day10Input.Data;
            var d = new Day10(input, 17, 61);
            d.InitializeBots();
            d.RunInstructions();
            Console.WriteLine($"Day 10");
            Console.WriteLine($"------");
            Console.WriteLine($"The number of the bot that is responsible for comparing value-61 microchips with value-17 microchips is {d.GetBotResponsibleToCompare().Id}");
            Console.WriteLine($"The result of multiply together the values of one chip in each of outputs 0, 1, and 2 is {d.Outputs[0].Chip * d.Outputs[1].Chip * d.Outputs[2].Chip}");
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
