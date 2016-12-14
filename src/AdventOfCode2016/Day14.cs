using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Security.Cryptography;

namespace AdventOfCode1016
{
    public class Day14
    {
        public string Salt = "zpqevtbw";
        public Dictionary<int, string> PrecompiledHashes = new Dictionary<int, string>();
        public int LastPrecompiledIndex = -1;
        
        public Day14 ()
        {
           PrecompileHashes();
        }

        public Day14 (string salt)
        {
           Salt = salt;
           PrecompileHashes();
        }

        private void PrecompileHashes (int numToPrecompile = 10000) {
            var startIndex = LastPrecompiledIndex + 1;
            var lastIndex = startIndex + numToPrecompile - 1;
            for (var i =  startIndex ; i <= lastIndex ; i++) {
                using (MD5 md5Hash = MD5.Create())
                {
                    string hash = GetMd5Hash(md5Hash, $"{Salt}{i}");
                    PrecompiledHashes.Add(i, hash);
                }
            }
            LastPrecompiledIndex = lastIndex;
        }

        public int ReturnNthValidKey (int nthValidKeyNumber = 1) {
            var validHashIndex = -1;
            var cpt = 1;
            foreach (var idx in FindValidHash()) {
                validHashIndex = idx;
                if (cpt == nthValidKeyNumber) {
                    break;
                }
                cpt++;
            }
            return validHashIndex;
        }

        public IEnumerable<int> FindValidHash () {
            var index = 0;
            while (true) {
                if (LastPrecompiledIndex < index) {
                    PrecompileHashes();
                }
                string hash = PrecompiledHashes[index];
                var findChar = ContainsAnyCharNTimes(hash);
                if (findChar != '.' && NextNHashesAreValid(index + 1, findChar, 1000)) {
                    yield return index;
                }
                index++;
            }
        }

        public bool NextNHashesAreValid (int startIndex, char lookFor, int numberOfHashesToTest) {
            if (LastPrecompiledIndex < startIndex + numberOfHashesToTest) {
                PrecompileHashes();
            }
            for (int i = startIndex ; i <= startIndex + numberOfHashesToTest ; i++) {
                if (ContainsCharNTimes(PrecompiledHashes[i], lookFor)) {
                    return true;
                }
            }
            return false;
        }

        private char ContainsAnyCharNTimes(string input, int numOftimes = 3) {
            string pattern = $"([0-9a-z])\\1{{{numOftimes - 1}}}";
            MatchCollection matches = Regex.Matches(input, pattern);
            if (matches.Count > 0) {
                return matches[0].Value[0];
            }
            return '.';
        }

        private bool ContainsCharNTimes(string input, char lookFor, int numOftimes = 5) {
            string pattern = $"{lookFor}{{{numOftimes}}}";
            MatchCollection matches = Regex.Matches(input, pattern);
            if (matches.Count > 0) {
                return true;
            }
            return false;
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