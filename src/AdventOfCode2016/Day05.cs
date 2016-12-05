using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Security.Cryptography;

namespace AdventOfCode1016
{
    public class Day05
    {
        private static string _mask = "00000";

        public Day05()
        {
            
        }

        public static string FindPassword (string id, int numOfChar = 8) 
        {
            var i = 0;
            var password = String.Empty;
            foreach (var c in Day05.FindChar(id)) {
                password += c;
                i++;
                if (i == numOfChar) { break; }
            }
            return password;
        }

        private static IEnumerable<char> FindChar (string id) {
            var index = 0;
            while (true) {
                using (MD5 md5Hash = MD5.Create())
                {
                    string hash = GetMd5Hash(md5Hash, $"{id}{index}");
                    if (hash.Substring(0,5) == _mask) {
                        yield return (char) hash[5];
                    }
                }
                index++;
            }
        }

        private static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

    }
}
