using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Security.Cryptography;

namespace AdventOfCode1016
{
    public class Day15
    {     
        public List<Disc> Discs = new List<Disc>();
        public int Time = 0;
        
        public Day15 ()
        {
           Discs.Add(new Disc(17, 15));
           Discs.Add(new Disc(3, 2));
           Discs.Add(new Disc(19, 4));
           Discs.Add(new Disc(13, 2));
           Discs.Add(new Disc(7, 2));
           Discs.Add(new Disc(5, 0));
        }

        public Day15 (List<Disc> discs)
        {
           foreach (var d in discs) {
               Discs.Add(new Disc(d.NumberOfPositions, d.CurrentPosition));
           }
        }

        public void AddDisc (Disc d) {
            Discs.Add(new Disc(d.NumberOfPositions, d.CurrentPosition));
        }

        public void NextTick () {
            Time++;
            foreach (var disc in Discs) {
                disc.MoveNext();
            }
        }

        public bool AreAllSlotsWillBeAlignedInSequence () {
            var sum = 0;
            for (var i  = 0 ; i < Discs.Count ; i++) {
                var d = Discs[i];
                sum += d.SimulateMoveNext(i + 1);
                if (sum > 0) {
                    return false;
                }
            }
            return true;
        }

        public int PushButtonToFallThrough () {
            while (!AreAllSlotsWillBeAlignedInSequence()) {
                NextTick();
            }
            return Time;
        }

    }

    public class Disc {

        public int NumberOfPositions = 1;
        private int _currentPosition;
        public int CurrentPosition {
            get {return _currentPosition;}
            set {
                _currentPosition = value;
                if (_currentPosition >= NumberOfPositions) {
                    _currentPosition = 0;
                }
            }
        }

        public Disc (int numOfPositions, int startingPosition){
            NumberOfPositions = numOfPositions;
            CurrentPosition = startingPosition;
        }

        public void MoveNext () {
            CurrentPosition++;
        }

        public void MoveNext (int next) {
            for (int i = 0 ; i < next ; i++) {
                MoveNext();
            }
        }

        public int SimulateMoveNext (int next) {
            var simulatedPosition = _currentPosition;
            for (int i = 0 ; i < next ; i++) {
                simulatedPosition++;
                if (simulatedPosition >= NumberOfPositions) {
                    simulatedPosition = 0;
                }
            }
            return simulatedPosition;
        }
    }
}