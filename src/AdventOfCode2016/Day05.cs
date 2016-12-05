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

        public static string FindMoreSophisticatedPassword (string id, int numOfChar = 8) 
        {
            var i = 0;
            var currentPassword = "........";
            foreach (var hash in Day05.FindChar(id, 2)) {
                var newPassword = FillPassword(currentPassword, hash);
                if (currentPassword != newPassword) {
                   currentPassword = newPassword;
                   i++;
                }
                if (i == numOfChar) { break; }
            }
            return currentPassword;
        }

        private static string FillPassword (string password, string hash) {
            
            if (!Char.IsDigit(hash[0])) {
                return password;
            }
            
            var updatedPassword = new StringBuilder(password);
            var passwordChar = hash[1];
            var position = 0;
            Int32.TryParse(hash[0].ToString(), out position);
            if (position < 8 && password[position] == '.') {
                updatedPassword[position] = passwordChar;
            }
            return updatedPassword.ToString();
        }

        private static IEnumerable<string> FindChar (string id, int numOfChar = 1) {
            var index = 0;
            while (true) {
                using (MD5 md5Hash = MD5.Create())
                {
                    string hash = GetMd5Hash(md5Hash, $"{id}{index}");
                    if (hash.Substring(0,5) == _mask) {
                        yield return hash.Substring(5, numOfChar);
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
