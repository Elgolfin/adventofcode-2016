using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Security.Cryptography;

namespace AdventOfCode1016
{
    public class Day16
    {     
        public Day16 ()
        {
           
        }

        public static string FillDisk (string initialState, int lengthAtLeast)
        {
            var data = initialState;
            while (data.Length < lengthAtLeast) {
                //Console.WriteLine(data);
                data = GenerateData(data);
            }
            //Console.WriteLine("-------------------");
            data = data.Substring(0, lengthAtLeast);
            //Console.WriteLine(data);
            //Console.WriteLine("-------------------");

            var checksum = GenerateChecksum(data);
            //Console.WriteLine(checksum);
            //Console.WriteLine("-------------------");

            return checksum;
        }

        public static string GenerateData (string a)
        {
            var b = Reverse(a);
            b = SwitchBits(b);
            var data = $"{a}0{b}";
            return data;
        }

        // Reverse the order of the characters
        public static string Reverse (string text)
        {
            if (text == null) { return String.Empty; }
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return (new string(array));
        }

        // Replace all instances of 0 with 1 and all 1s with 0.
        public static string SwitchBits (string text)
        {
            var result = text.Replace("0",".");
            result = result.Replace("1","0");
            result = result.Replace(".","1");
            return result;
        }

        public static string GenerateChecksum (string input) {
            var result = new StringBuilder();
            for (var i = 0 ; i < input.Length ; i += 2)
            {
                if (input[i] == input[i+1]) {
                    result.Append("1");
                } else {
                    result.Append("0");
                }
            }
            
            if (result.Length % 2 == 0) {
                return GenerateChecksum(result.ToString());
            } else {
                return result.ToString();
            }
        }

    }
}