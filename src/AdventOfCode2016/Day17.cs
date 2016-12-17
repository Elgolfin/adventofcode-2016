using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Security.Cryptography;

namespace AdventOfCode1016
{
    public class Day17
    {     
        string Passcode = "mmsxrhfx";
        Vault Vault;
        Queue<string> _Paths = new Queue<string>();
        List<string> VisitedPaths = new List<string>();
        List<string> AllPathsToExit = new List<string>();
        
        public Day17 (string passcode = "mmsxrhfx")
        {
           Passcode = passcode;
           Vault = new Vault();
        }

        public int FindLongestPathToExit () {
            return FindPathToExit(false).Length;
        }

        // If shortest = false, the program will find all paths who lead to the exit
        public string FindPathToExit (bool shortest = true)
        {
            var path = String.Empty;
            _Paths.Enqueue($"{Vault.Root}|{Passcode}");
            while (_Paths.Count > 0) {
                var currentRoomInQueue = _Paths.Dequeue();
                var currentRoom = Vault.Rooms[currentRoomInQueue.Split('|')[0]];
                var currentPasscode = currentRoomInQueue.Split('|')[1];
                VisitedPaths.Add(currentPasscode);
                currentRoom.SetPasscode(currentPasscode);
                var nextRooms = currentRoom.GetNextAvailableRooms();
                foreach (var nextRoom in nextRooms) {
                    var nextRoomPasscode = $"{currentPasscode}{nextRoom.Key}";
                    if (nextRoom.Value == Vault.Exit) { 
                        path = nextRoomPasscode.Replace(Passcode, "");
                        // If we do not break, the last time we go in here, it will be the last and longest path who lead to the exit
                        if (shortest) {
                            _Paths.Clear();
                            break;
                        }
                        AllPathsToExit.Add(nextRoomPasscode.Replace(Passcode, ""));
                    } else {
                        _Paths.Enqueue($"{nextRoom.Value}|{nextRoomPasscode}");
                    }
                }
            }
            return path;
        }

    }

    public class Vault {
        public int Width = 4;
        public int Height = 4;
        public Dictionary<string,VaultRoom> Rooms = new Dictionary<string, VaultRoom>();
        public VaultRoom Root;
        public VaultRoom Exit;

        public Vault (int width = 4, int height = 4) {
            Width = width;
            Height = height;
            InitializeVault();
        }

        private void InitializeVault () {
            // Create the rooms and link them together
            for (int x = 0 ; x < Width ; x++) {
                for (int y = 0 ; y < Height ; y++) {
                    Rooms.Add($"{x},{y}", new VaultRoom(x, y, this));
                }
            }
            foreach (var room in Rooms.Values) {
                if (room.X - 1 >= 0) {
                    room.Left = Rooms[$"{room.X - 1},{room.Y}"];
                }
                if (room.X + 1 < Width) {
                    room.Right = Rooms[$"{room.X + 1},{room.Y}"];
                }
                if (room.Y - 1 >= 0) {
                    room.Up = Rooms[$"{room.X},{room.Y - 1}"];
                }
                if (room.Y + 1 < Height) {
                    room.Down = Rooms[$"{room.X},{room.Y + 1}"];
                }
            }
            Root = Rooms["0,0"];
            Exit = Rooms[$"{Width - 1},{Height - 1}"];
        }
    }

    public class VaultRoom
    {
        public Vault Vault;
        public VaultRoom Left;
        public VaultRoom Right;
        public VaultRoom Up;
        public VaultRoom Down;
        public int X;
        public int Y;
        public bool IsPathToLeftOpened = false; // Default, wall or door is closed
        public bool IsPathToRightOpened = false;
        public bool IsPathToUpOpened = false;
        public bool IsPathToDownOpened = false;
        Stack<string> Passcodes = new Stack<string>();

        public string CurrentPasscode {
            get {
                return Passcodes.Peek();
            }
            set {}
        }

        public VaultRoom (int x, int y, Vault vault) {
            X = x;
            Y = y;
            Vault = vault;
        }

        public void SetPasscode (string passcode) {
            Passcodes.Push(passcode);
            SetAvailablePaths(passcode);
        }

        public Dictionary<string, VaultRoom> GetNextAvailableRooms (){
            var nextRooms = new Dictionary<string, VaultRoom>();
            if (IsPathToDownOpened) {
                nextRooms.Add("D", Down);
            }
            if (IsPathToUpOpened) {
                nextRooms.Add("U", Up);
            }
            if (IsPathToLeftOpened) {
                nextRooms.Add("L", Left);
            }
            if (IsPathToRightOpened) {
                nextRooms.Add("R", Right);
            }
            return nextRooms;
        }

        private void SetAvailablePaths (string passcode) {
            var hash = String.Empty;
            using (MD5 md5Hash = MD5.Create())
            {
                hash = GetMd5Hash(md5Hash, passcode);
            }
            // up = 0, down = 1, left = 2, and right = 3
            // Check for wall on the top border; 0 and down top border is always a wall
            if (Y > 0) {
                IsPathToUpOpened = Char.IsLetter(hash[0]) && hash[0] != 'a';
            }
            // Check for wall on the bottom border; 3 and up bottom border is always a wall
            if (Y < Vault.Height - 1) {
                IsPathToDownOpened = Char.IsLetter(hash[1]) && hash[1] != 'a';
            }
            // Check for wall on the left border; 0 and down left border is always a wall
            if (X > 0) {
                IsPathToLeftOpened = Char.IsLetter(hash[2]) && hash[2] != 'a';
            }
            // Check for wall on the right border; 3 and up right border is always a wall
            if (X < Vault.Width - 1) {
                IsPathToRightOpened = Char.IsLetter(hash[3]) && hash[3] != 'a';
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

        public override string ToString() {
            return $"{X},{Y}";
        }
    }
}