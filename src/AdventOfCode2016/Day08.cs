using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace AdventOfCode1016
{
    public class Day08
    {
        public string Input;
        public List<Command> Commands = new List<Command>();
        public char[,] Screen;

        public Day08(string input, int screenX = 6, int screenY = 50)
        {
            Input = input;
            ParseCommands();
            InitializeScreen(screenX, screenY);
        }

        public int NumberOfLitPixels ()
        {
            var litPixels = 0;
            var boundY = Screen.GetUpperBound(0);
            var boundX = Screen.GetUpperBound(1);
            for (var y = 0; y <= boundY; y++)
            {
                for (var x = 0; x <= boundX; x++)
                {
                    if (Screen[y, x] == '#')
                    {
                        litPixels++;
                    }
                }
            }
            return litPixels;
        }

        public override string ToString()
        {
            var boundY = Screen.GetUpperBound(0);
            var boundX = Screen.GetUpperBound(1);
            var screen = new StringBuilder();
            for (var y = 0; y <= boundY; y++)
            {
                for (var x = 0; x <= boundX; x++)
                {
                    screen.Append(Screen[y, x]);
                }
                screen.Append("\n");
            }
            return screen.ToString();
        }

        private void InitializeScreen(int screenX = 6, int screenY = 50) 
        {
            Screen = new char[screenX, screenY];
            int boundY = Screen.GetUpperBound(0);
            int boundX = Screen.GetUpperBound(1);
            for (int y = 0; y <= boundY; y++)
            {
                for (int x = 0; x <= boundX; x++)
                {
                    Screen[y, x] = '.';
                }
            }
        }

        private void ParseCommands ()
        {
        var lines = Input.Split('\n').Select(p => p.Trim()).ToList();
            foreach (var line in lines) {
                if (!String.IsNullOrEmpty(line)) {
                    Commands.Add(new Command(line));
                }
            }
        }

        public void Run ()
        {
            foreach (var command in Commands)
            {
                Screen = command.Run(Screen);
            }
        }

    }

    public class Command 
    {
        public string Input;
        public int X;
        public int Y;
        public Type Name;
        public int By;

        public enum Type {Rect, Rotate_Row, Rotate_Column}; 

        public Command (string input) {
            Input = input;
            ParseInput();
        }

        public char[,] Run (char[,] screen) 
        {
            switch (Name) {
                case Type.Rect:
                    return RunRect(screen);
                case Type.Rotate_Column:
                    return RotateColumn(screen);
                case Type.Rotate_Row:
                    return RotateRow(screen);
                default:
                    return screen;
            }
        }

        private char[,] RunRect (char[,] screen)
        {
            var newScreen = screen;
            for (int y = 0 ; y < Y ; y++) {
                for (int x = 0 ; x < X ; x++) {
                    newScreen[y, x] = '#';
                }
            }
            return newScreen;
        }

        private char[,] RotateColumn (char[,] screen)
        {
            var newScreen = screen;
            var columnData = new StringBuilder();
            int boundY = screen.GetUpperBound(0);
            for (int y = 0; y <= boundY; y++)
            {
                columnData.Append(screen[y, X]);
            }
            
            var newColumnData = columnData.ToString();
            for (int shiftBy = 0 ; shiftBy < By; shiftBy++) {
                newColumnData = newColumnData[newColumnData.Length - 1] + newColumnData.Substring(0, newColumnData.Length - 1);
            }
            
            for (int y = 0; y <= boundY; y++)
            {
                newScreen[y, X] = newColumnData[y];
            }            
            return newScreen;
        }

        private char[,] RotateRow (char[,] screen)
        {
            var newScreen = screen;
            var columnData = new StringBuilder();
            int boundX = screen.GetUpperBound(1);
            for (int x = 0; x <= boundX; x++)
            {
                columnData.Append(screen[Y, x]);
            }
            
            var newColumnData = columnData.ToString();
            for (int shiftBy = 0 ; shiftBy < By; shiftBy++) {
                newColumnData = newColumnData[newColumnData.Length - 1] + newColumnData.Substring(0, newColumnData.Length - 1);
            }
            
            for (int x = 0; x <= boundX; x++)
            {
                newScreen[Y, x] = newColumnData[x];
            }            
            return newScreen;
        }

        private void ParseInput ()
        {
            ParseRect();
            ParseRow();
            ParseColumn();

        }

        private void ParseRect () {
            var pattern = "rect (?<x>[0-9]+)x(?<y>[0-9]+)";
            var regex = new Regex(pattern);
            var match = regex.Match(Input);
            if (match.Success)
            {
                Name = Type.Rect;
                Int32.TryParse(match.Groups["x"].Value, out X);
                Int32.TryParse(match.Groups["y"].Value, out Y);
            }
        }

        private void ParseRow () {
            var pattern = "rotate row y=(?<y>[0-9]+) by (?<by>[0-9]+)";
            var regex = new Regex(pattern);
            var match = regex.Match(Input);
            if (match.Success)
            {
                Name = Type.Rotate_Row;
                Int32.TryParse(match.Groups["y"].Value, out Y);
                Int32.TryParse(match.Groups["by"].Value, out By);
            }
        }

        private void ParseColumn () {
            var pattern = "rotate column x=(?<x>[0-9]+) by (?<by>[0-9]+)";
            var regex = new Regex(pattern);
            var match = regex.Match(Input);
            if (match.Success)
            {
                Name = Type.Rotate_Column;
                Int32.TryParse(match.Groups["x"].Value, out X);
                Int32.TryParse(match.Groups["by"].Value, out By);
            }
        }

    }
}
