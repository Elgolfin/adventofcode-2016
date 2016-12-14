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
        public int KeyStretching = 0;
        
        public Day14 ()
        {
           PrecompileHashes();
        }

        public Day14 (int stretching)
        {
           KeyStretching = stretching;
           PrecompileHashes();
        }

        public Day14 (string salt)
        {
           Salt = salt;
           PrecompileHashes();
        }

        public Day14 (string salt, int stretching)
        {
           Salt = salt;
           KeyStretching = stretching;
           PrecompileHashes();
        }

        private void PrecompileHashes (int numToPrecompile = 1000) {
            var startIndex = LastPrecompiledIndex + 1;
            var lastIndex = startIndex + numToPrecompile - 1;
            for (var i =  startIndex ; i <= lastIndex ; i++) {
                var hash = KeyStretchingMD5Hash($"{Salt}{i}", KeyStretching);
                PrecompiledHashes.Add(i, hash);
            }
            LastPrecompiledIndex = lastIndex;
        }

        public static string KeyStretchingMD5Hash (string strToHash, int n = 0) {
            var hash = String.Empty;;
            using (MD5 md5Hash = MD5.Create())
            {
                hash = GetMd5Hash(md5Hash, strToHash);
                for (var j = 1 ; j <= n ; j++) {
                    hash = GetMd5Hash(md5Hash, hash);
                }
            }
            return hash;
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