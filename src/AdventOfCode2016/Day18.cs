using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Security.Cryptography;

namespace AdventOfCode1016
{
    public class Day18
    {     
        public string Input;
        public string Room;
        public Day18 ()
        {
           
        }
        public Day18 (string input)
        {
           Input = input;
        }

        public int GetNumberOfSafeTiles (int numberOfRows) {
            var room = new StringBuilder();
            var previousRow = Input;
            room.AppendLine(previousRow);
            for (int i = 1 ; i < numberOfRows ; i++) {
                var newRow = CreateRow(previousRow);
                room.AppendLine(newRow);
                previousRow = newRow;
            }
            Room = room.ToString();
            return CountSafeTiles();
        }

        private int CountSafeTiles () {
            return CountChar(Room, '.');
        }

        private int CountChar (string input, char charToBeCounted) {
            int count = 0;
            foreach (char c in input) {
                if (c == charToBeCounted) { count++; }
            }
            return count;
        }

        public string CreateRow (string previousRow) {
            var newRow = new StringBuilder();
            var to = previousRow.Length;
            var tempRow = $".{previousRow}.";
            for (var i = 1; i <= to; i++) {
                if (IsNewTileSafe(tempRow[i-1], tempRow[i], tempRow[i+1])) {
                    newRow.Append('.');
                } else {
                    newRow.Append('^');
                }
            }
            return newRow.ToString();
        }

        /// A new tile is a trap only in one of the following situations:
        /// Its left and center tiles are traps, but its right tile is not.
        /// Its center and right tiles are traps, but its left tile is not.
        /// Only its left tile is a trap.
        /// Only its right tile is a trap.
        /// In any other situation, the new tile is safe.
        public bool IsNewTileSafe (char left, char center, char right) {

            // Its left and center tiles are traps, but its right tile is not.
            if (left  == '^' && center == '^' && right == '.') { return false; }

            // Its center and right tiles are traps, but its left tile is not.
            if (left  == '.' && center == '^' && right == '^') { return false; }

            // Only its left tile is a trap.
            if (left  == '^' && center == '.' && right == '.') { return false; }

            // Only its right tile is a trap.
            if (left  == '.' && center == '.' && right == '^') { return false; }

            return true;
        }

    }

    
}