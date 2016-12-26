using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace AdventOfCode1016
{
    public class Day24
    {
        public string Input;
        public Dictionary<string, Location> Map = new Dictionary<string, Location>();
        public int Width;
        public int Height;
        public Dictionary<string, int> DistancesBetweenDestinations = new Dictionary<string, int>();
        public char LastRoundTripLocation = ' ';

        public Day24(string input)
        {
            Input = input;
            ParseLines();
        }

        public int FindFewestStepsBetweenAllDestinations (string destinations, char startFrom = '0', bool returnToStart = false) {
            var permutations = GetAllPermutations(destinations.Substring(1));
            var minDistance = 9999999;
            foreach (var permutation in permutations) {
                var currentDistance = 0;
                var from = destinations[0];
                var to = ' ';
                var fullPermutation = permutation;
                if (returnToStart) {
                    fullPermutation = $"{permutation}{startFrom}";
                }
                foreach (var destination in fullPermutation) {
                    to = destination;
                    var route = $"{from},{to}";
                    if (!DistancesBetweenDestinations.ContainsKey(route)) {
                        var d = FindShortestDistance(from, to);
                        DistancesBetweenDestinations[route] = d;
                    }
                    currentDistance += DistancesBetweenDestinations[route];
                    if (currentDistance >= minDistance) {
                        break;
                    }
                    from = to;
                }
                if (currentDistance < minDistance) {
                    minDistance = currentDistance;
                    LastRoundTripLocation = from;
                }
                minDistance = Math.Min(minDistance, currentDistance);
            }
            return minDistance;
        }

        /// In short:
        /// 1. The permutation of 1 element is one element.
        /// 2. The permutation of a set of elements is a list each of the elements, concatenated with every permutation of the other elements.
        ///
        /// Example:
        ///
        /// If the set just has one element -->
        /// return it.
        /// perm(a) -> a
        ///
        /// If the set has two characters: for each element in it: return the element, with the permutation of the rest of the elements added, like so:
        ///
        /// perm(ab) ->
        /// a + perm(b) -> ab
        /// b + perm(a) -> ba
        ///
        /// Further: for each character in the set: return a character, concatenated with a perumation of > the rest of the set
        ///
        /// perm(abc) ->
        /// a + perm(bc) --> abc, acb
        /// b + perm(ac) --> bac, bca
        /// c + perm(ab) --> cab, cba
        ///
        /// perm(abc...z) -->
        /// a + perm(...), b + perm(....)
        /// ....
        public static List<string> GetAllPermutations (string input) {
            if (input.Length == 1) {
                return new List<string>() {input};
            }
            var result = new List<string>();
            for (var index  = 0 ; index < input.Length; index++) {
                var currentChar = input[index];
                var stringToPermute = new StringBuilder(input);
                stringToPermute.Remove(index, 1);
                var permutations = GetAllPermutations(stringToPermute.ToString());
                foreach (var permutation in permutations) {
                    result.Add($"{currentChar}{permutation}");
                }
            }
            return result;
        }

        public void Reset() {
            ParseLines();
        }

        public Location GetDestinationLocation (char c) {
            return Map.Values.Where(n => n.Symbol == c).First();
        }

        public int FindShortestDistance (char from, char to)
        {
            var fromLocation = GetDestinationLocation(from);
            var toLocation = GetDestinationLocation(to);
            return FindShortestDistance(fromLocation, toLocation);
        }

        public int FindShortestDistance (string from, string to)
        {
            return FindShortestDistance(Map[from], Map[to]);
        }

        public int FindShortestDistance (Location from, Location to)
        {
            var _Paths = new Queue<string>();
            _Paths.Enqueue(from.Key);
            from.DistanceFromRoot = 0;
            var visitedLocations = new List<string>();
            var currentLocation = from;
            while (_Paths.Count > 0) {
                var currentQueueElement = _Paths.Dequeue();
                var currentLocationId = currentQueueElement.Split('|').Last();
                currentLocation = Map[currentLocationId];
                if (currentLocation.Key == to.Key) {
                    return currentLocation.DistanceFromRoot;
                }
                if (visitedLocations.Contains(currentLocation.Key)) {
                    continue;
                }
                foreach (var adjacentLocation in currentLocation.AdjacentLocations) {
                    if (!visitedLocations.Contains(adjacentLocation.Key) && !adjacentLocation.IsWall) { 
                        adjacentLocation.DistanceFromRoot = currentLocation.DistanceFromRoot + 1;
                        _Paths.Enqueue($"{currentQueueElement}|{adjacentLocation.Key}");
                    }
                }
                visitedLocations.Add(currentLocation.Key);
                
            }
            return -1;
        }

        private void ParseLines () {
            Map = new Dictionary<string, Location>();
            var lines = Input.Split('\n').Select(p => p.Trim()).ToList();
            var row = 0;
            foreach (var line in lines) {
                if (!String.IsNullOrEmpty(line)) {
                    var column = 0;
                    foreach (var c in line) {
                        if (c == '#' || c =='.' || char.IsDigit(c)) {
                            var location = new Location(row, column, c);
                            Map.Add(location.Key, location);
                            Width = Math.Max(Width, location.X + 1);
                            Height = Math.Max(Height, location.Y + 1);
                        }
                        column++;
                    }
                    row++;
                }
            }
            
            // Link the nodes together
            foreach (var location in Map.Values) {
                if (location.X - 1 >= 0) {
                    var locationToAdd = Map[$"{location.X - 1},{location.Y}"];
                    location.AdjacentLocations.Add(locationToAdd);
                }
                if (location.X + 1 < Width) {
                    var locationToAdd = Map[$"{location.X + 1},{location.Y}"];
                    location.AdjacentLocations.Add(locationToAdd);
                }
                if (location.Y - 1 >= 0) {
                    var locationToAdd = Map[$"{location.X},{location.Y - 1}"];
                    location.AdjacentLocations.Add(locationToAdd);
                }
                if (location.Y + 1 < Height) {
                    var locationToAdd = Map[$"{location.X},{location.Y + 1}"];
                    location.AdjacentLocations.Add(locationToAdd);
                }
            }
        }
    }

    public class Location
    {
        public int X {get; set;}
        public int Y {get; set;}
        public int DistanceFromRoot;
        public bool HasBeenVisited {get; set;}
        public Coordinate Predecessor {get; set;}
        public bool IsWall {
            get {
                return Symbol == '#' ? true : false;
            }
            set {}}
        public bool IsDestination {
            get {
                return char.IsDigit(Symbol) ? true : false;
            }
             set{}
        }
        public char Symbol {get; set;}
        public string Key {
            get {
                return $"{X},{Y}";
            }
            set {

            }
        }

        public List<Location> AdjacentLocations = new List<Location>();

        public Location (int x, int y, char symbol) {
            X = x;
            Y = y;
            Symbol = symbol;
        }

        public override bool Equals (Object c) {
            return ((Location) c).X == X && ((Location) c).Y == Y;
        }

        public override int GetHashCode () {
            return X * Y;
        }

    }
    
}
