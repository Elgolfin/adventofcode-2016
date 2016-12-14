using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace AdventOfCode1016
{
    public class Day13
    {
        public string Input;
        public int DesignerFavoriteNumber = 1352;
        public int Width;
        public int Height;
        public Dictionary<string, Coordinate> Maze = new Dictionary<string, Coordinate>();
        public Coordinate Root;

        public Day13(int rootX = 1, int rootY = 1, int width = 10, int height = 10, int favoriteNumber = 1352)
        {
            Width = width;
            Height = height;
            DesignerFavoriteNumber = favoriteNumber;
            var rootKey = $"{rootX},{rootY}";
            Maze.Add(rootKey, new Coordinate(rootX, rootY));
            Root = Maze[rootKey];
        }

        public bool IsOpenSpace (int x, int y) 
        {
            bool isOpenSpace = false;

            if (x < 0 || y < 0) {
                return isOpenSpace;
            }

            if (x >= Width || y >= Height) {
                return isOpenSpace;
            }

            int value = x*x + 3*x + 2*x*y + y + y*y;
            value += DesignerFavoriteNumber;
            if (CountSetBits(value) % 2 == 0) {
                isOpenSpace = true;
            }
            return isOpenSpace;
        }

        public bool IsWall (int x, int y) 
        {
            return !IsOpenSpace(x, y);
        }

        private int CountSetBits(int number)
        {
            var tmpHand = number;
            var cpt = 0;
            while (tmpHand > 0)
            {
                if ((tmpHand & 0x1) == 1)
                {
                    cpt++;
                }
                tmpHand >>= 1;
            }
            return cpt;
        }

        public string DrawMap ()
        {
            var map = new StringBuilder();
            for (int y  = 0 ; y < Height ; y++) {
                var line = new StringBuilder();
                for (int x  = 0 ; x < Height ; x++) {
                    if (IsOpenSpace(x, y)) {
                        line.Append('.');
                    } else {
                        line.Append('#');
                    }
                }
                map.AppendLine(line.ToString());
            }
            return map.ToString();
        }
        
        public void InitializeMaze (Coordinate from, string toKey = "")
        {
            var q = new Queue<Coordinate>();
            from.Predecessor = null;
            from.DistanceFromRoot = 0;
            q.Enqueue(from);
            var currentLocation = from;

            while (q.Count() > 0) {
                currentLocation = q.Dequeue();
                var connectedSpaces = GetAllConnectedOpenSpaces(currentLocation);
                foreach (var connectedSpace in connectedSpaces) {
                    if (!connectedSpace.HasBeenVisited) {
                        connectedSpace.Predecessor = currentLocation;
                        connectedSpace.DistanceFromRoot = currentLocation.DistanceFromRoot + 1;
                        q.Enqueue(connectedSpace);
                    }
                }
                currentLocation.HasBeenVisited = true;
            }
        }

        public int FindDistanceToLocation (string toKey = "")
        {
            var q = new Queue<Coordinate>();
            var from = Root;
            from.Predecessor = null;
            from.DistanceFromRoot = 0;
            q.Enqueue(from);
            var currentLocation = from;

            while (q.Count() > 0) {
                currentLocation = q.Dequeue();
                // We have reach the location, return the distance from the root
                if (!String.IsNullOrEmpty(toKey) && currentLocation.Key == toKey) {
                    return currentLocation.DistanceFromRoot;
                }
                var connectedSpaces = GetAllConnectedOpenSpaces(currentLocation);
                foreach (var connectedSpace in connectedSpaces) {
                    if (!connectedSpace.HasBeenVisited) {
                        connectedSpace.Predecessor = currentLocation;
                        connectedSpace.DistanceFromRoot = currentLocation.DistanceFromRoot + 1;
                        q.Enqueue(connectedSpace);
                    }
                }
                currentLocation.HasBeenVisited = true;
            }

            return -1;
        }

        public int CountLocationWithinNSteps (int steps)
        {
            var q = new Queue<Coordinate>();
            var from = Root;
            from.Predecessor = null;
            from.DistanceFromRoot = 0;
            q.Enqueue(from);
            var currentLocation = from;

            while (q.Count() > 0) {
                currentLocation = q.Dequeue();
                // We've proceed all the locations wihtin the required steps, stop the loop here
                if (currentLocation.DistanceFromRoot > steps) {
                    break;
                }
                var connectedSpaces = GetAllConnectedOpenSpaces(currentLocation);
                foreach (var connectedSpace in connectedSpaces) {
                    if (!connectedSpace.HasBeenVisited) {
                        connectedSpace.Predecessor = currentLocation;
                        connectedSpace.DistanceFromRoot = currentLocation.DistanceFromRoot + 1;
                        q.Enqueue(connectedSpace);
                    }
                }
                currentLocation.HasBeenVisited = true;
            }

            return Maze.Values.Where(c => c.DistanceFromRoot <= steps).Count();
        }

        public List<Coordinate> GetAllConnectedOpenSpaces (Coordinate c, Dictionary<string,Coordinate> exclude = null) {
            
            var connectedSpaces = new List<Coordinate>();
            var key = String.Empty;
            
            // Right
            key = AddConnectedSpace(c.X + 1, c.Y);
            if (!String.IsNullOrEmpty(key)){
                connectedSpaces.Add(Maze[key]);
            }
            
            // Top
            key = AddConnectedSpace(c.X, c.Y - 1);
            if (!String.IsNullOrEmpty(key)){
                connectedSpaces.Add(Maze[key]);
            }
            
            // Left
            key = AddConnectedSpace(c.X - 1, c.Y);
            if (!String.IsNullOrEmpty(key)){
                connectedSpaces.Add(Maze[key]);
            }
            
            // Bottom
            key = AddConnectedSpace(c.X, c.Y + 1);
            if (!String.IsNullOrEmpty(key)){
                connectedSpaces.Add(Maze[key]);
            }
            
            return connectedSpaces;
        }

        private string AddConnectedSpace (int x, int y) {
            var key = String.Empty;
            if (IsOpenSpace(x, y)) {
                key = $"{x},{y}";
                if (!Maze.Keys.Contains(key)) {
                    Maze.Add(key, new Coordinate(x, y));
                }
            }
            return key;
        }

    }

    public class Coordinate
    {
        public int X {get; set;}
        public int Y {get; set;}
        public int DistanceFromRoot;
        public bool HasBeenVisited {get; set;}
        public Coordinate Predecessor {get; set;}
        public string Key {
            get {
                return $"{X},{Y}";
            }
            set {

            }
        }

        public Coordinate (int x, int y) {
            X = x;
            Y = y;
        }

        public override bool Equals (Object c) {
            return ((Coordinate) c).X == X && ((Coordinate) c).Y == Y;
        }

        public override int GetHashCode () {
            return X * Y;
        }

    }

}