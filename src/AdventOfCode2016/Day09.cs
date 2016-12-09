using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace AdventOfCode1016
{
    public class Day09
    {
        public string Input;
        public string DecompressedInput;
        public string DecompressedInput_v2;
        public ulong DecompressedInput_v2_Length;

        public Day09(string input)
        {
            Input = input;
            DecompressedInput = Decompress();
            // Will throw an OutOfMemoryException with large uncompressed files
            //DecompressedInput_v2 = Decompress_v2();
            DecompressedInput_v2_Length = Decompress_v21(Input);
        }

        public string Decompress_v2 ()
        {
            var decompressedString_v2 = String.Empty;
            decompressedString_v2 = Decompress(DecompressedInput);
            while (decompressedString_v2.Contains("(")) {
                decompressedString_v2 = Decompress(decompressedString_v2);
            }
            return decompressedString_v2;
        }

        public string Decompress ()
        {
            return Decompress(Input);
        }

        public string Decompress (string input)
        {
            var decompressedString = new StringBuilder();
            var numOfCharToBeRepeated = 0;
            var numOfTimesToBeRepeated = 0;
            var numOfCharToBeRepeated_Str = new StringBuilder();
            var numOfTimesToBeRepeated_Str = new StringBuilder();
            var i = 0;
            while (i < input.Length)
            {
                if (input[i] == '(') {

                    numOfCharToBeRepeated_Str = new StringBuilder();
                    numOfTimesToBeRepeated_Str = new StringBuilder();

                    i++;
                    while (input[i] != 'x') {
                        numOfCharToBeRepeated_Str.Append(input[i]);
                        i++;
                    }

                    i++;
                    while (input[i] != ')') {
                        numOfTimesToBeRepeated_Str.Append(input[i]);
                        i++;
                    }
                    Int32.TryParse(numOfCharToBeRepeated_Str.ToString(), out numOfCharToBeRepeated);
                    Int32.TryParse(numOfTimesToBeRepeated_Str.ToString(), out numOfTimesToBeRepeated);
                    
                    i++;
                    // Here var i is positioned on the closing parenthesis of the marker
                    // Repeat the sequence
                    var strToBeRepeated = input.Substring(i, numOfCharToBeRepeated);
                    for (int j = 0 ; j < numOfTimesToBeRepeated; j++) {
                        decompressedString.Append(strToBeRepeated);
                    }

                    i += numOfCharToBeRepeated - 1;

                } else {
                    decompressedString.Append(input[i]);
                }
                i++;
            }
            return decompressedString.ToString();
        }

        /// Decompose the string in multipart (do it recursively if necessary)
        /// i.e.
        /// input: (25x3)(3x3)ABC(2x3)XY(5x2)PQRSTX(18x9)(3x2)TWO(5x7)SEVEN
        ///
        /// Part I
        /// (25x3)(3x3)ABC(2x3)XY(5x2)PQRST
        /// 3 x (3x3)ABC(2x3)XY(5x2)PQRST
        /// 3 x (9+6+10) = 75 chars
        ///
        /// Part II
        /// X
        /// 1 char
        ///
        /// Part III
        /// (18x9)(3x2)TWO(5x7)SEVEN
        /// 9 x (3x2)TWO(5x7)SEVEN
        /// 9 x (6 + 35) = 369 chars
        ///
        /// = 125 + 1 + 369
        /// = 445 chars total
        public ulong Decompress_v21 (string input)
        {
            ulong length = 0;
            var numOfCharToBeRepeated = 0;
            var numOfTimesToBeRepeated = 0;
            var numOfCharToBeRepeated_Str = new StringBuilder();
            var numOfTimesToBeRepeated_Str = new StringBuilder();
            var i = 0;
            while (i < input.Length)
            {
                if (input[i] == '(') {

                    numOfCharToBeRepeated_Str = new StringBuilder();
                    numOfTimesToBeRepeated_Str = new StringBuilder();

                    i++;
                    while (input[i] != 'x') {
                        numOfCharToBeRepeated_Str.Append(input[i]);
                        i++;
                    }

                    i++;
                    while (input[i] != ')') {
                        numOfTimesToBeRepeated_Str.Append(input[i]);
                        i++;
                    }
                    Int32.TryParse(numOfCharToBeRepeated_Str.ToString(), out numOfCharToBeRepeated);
                    Int32.TryParse(numOfTimesToBeRepeated_Str.ToString(), out numOfTimesToBeRepeated);
                    
                    i++;
                    // Here var i is positioned on the closing parenthesis of the marker
                    // Repeat the sequence
                    var strToBeRepeated = input.Substring(i, numOfCharToBeRepeated);
                    length += (ulong) numOfTimesToBeRepeated * Decompress_v21(strToBeRepeated);

                    i += numOfCharToBeRepeated - 1;

                } else {
                    length++;
                }
                i++;
            }
            return length;
        }

    }
}
