using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Security.Cryptography;

namespace AdventOfCode1016
{
    public class Day19
    {     
        public int NumberOfElves;
        public Queue<Elf> Elves = new Queue<Elf>();
        public Dictionary<int, Elf> ElvesD = new Dictionary<int, Elf>();
        public List<int> RemovedElves = new List<int>();
        public Day19 ()
        {
           
        }
        public Day19 (int input)
        {
           NumberOfElves = input;
           Initialize();
        }

        private void Initialize () {
            for (var i = 1 ; i <= NumberOfElves ; i++) {
                Elves.Enqueue(new Elf(i));
                ElvesD.Add(i, new Elf(i));
            }
        }

        public int GetElfWithAllPresents () {
            while (Elves.Count > 1) {
                var taker = Elves.Dequeue();
                var giver = Elves.Dequeue();
                taker.NumberOfPresents += giver.NumberOfPresents;
                Elves.Enqueue(taker);
            }
            return Elves.First().Id;
        }

        public int GetFormulaCrossPosition ()
        {
            int pow = (int)Math.Floor(Math.Log(NumberOfElves) / Math.Log(3));
            int b = (int)Math.Pow(3, pow);
            if (NumberOfElves == b)
                return NumberOfElves;
            if (NumberOfElves - b <= b)
                return NumberOfElves - b;
            return 2 * NumberOfElves - 3 * b;
        }

        /// Following methods are too much slow to run
        public int GetElfWithAllPresents_Across () {
            while (Elves.Count > 1) {
                
                var to = Elves.Count / 2;
                var taker = Elves.Dequeue();
                //Console.WriteLine($"Taker {taker}");
                var tmp = new Queue<Elf>();
                for (var i = 0 ; i < to -1 ; i++) {
                    tmp.Enqueue(Elves.Dequeue());
                }
                var giver = Elves.Dequeue();
                //Console.WriteLine($"Giver {giver}");
                while (Elves.Count > 0) {
                    tmp.Enqueue(Elves.Dequeue());
                }
                taker.NumberOfPresents += giver.NumberOfPresents;
                tmp.Enqueue(taker);
                Elves = tmp;
            }
            return Elves.First().Id;
        }

        public int GetElfWithAllPresents_AcrossD () {
            var cptElves = ElvesD.Count;
            var takerId = 1;
            while (cptElves > 1) {
                var taker = ElvesD[takerId];
                var to = ElvesD.Count / 2;
                var giverId = takerId;
                for (var i = 0 ; i < to ; i++) {
                    giverId = IncrementId(giverId);
                }
                var giver = ElvesD[giverId];
                taker.NumberOfPresents += giver.NumberOfPresents;
                ElvesD.Remove(giverId);
                RemovedElves.Add(giverId);
                cptElves = ElvesD.Count;
                takerId = IncrementId(takerId);
            }
            return ElvesD.Keys.First();
        }

        public int IncrementId (int id) {
            var newId = Enumerable.Range(id + 1, NumberOfElves).Except(RemovedElves).FirstOrDefault();
            if (newId < 1) {
                newId = Enumerable.Range(1, id - 1).Except(RemovedElves).FirstOrDefault();
            }
            if (newId > NumberOfElves) {
                newId = Enumerable.Range(1, NumberOfElves).Except(RemovedElves).FirstOrDefault();
            }
            return newId;
        }
    }

    

    public class Elf {

        public int Id;
        public int NumberOfPresents = 1;

        public Elf (int id) {
            Id = id;
        }

        public override string ToString() {
            return $"Elf {Id} ({NumberOfPresents} presents)";
        }

    }
}