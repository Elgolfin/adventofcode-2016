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
        public int Input;
        public int NumberOfElves;
        public Queue<Elf> Elves = new Queue<Elf>();
        public Day19 ()
        {
           
        }
        public Day19 (int input)
        {
           NumberOfElves = input;
           Initialize();
        }

        // While initializing the circle, we skip one elf over two (first loop to remove present will already be done)
        private void Initialize () {
            for (var i = 1 ; i <= NumberOfElves ; i += 2) {
                Elves.Enqueue(new Elf(i));
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
    }

    public class Elf {

        public int Id;
        public int NumberOfPresents = 1;

        public Elf (int id) {
            Id = id;
        }

    }
}