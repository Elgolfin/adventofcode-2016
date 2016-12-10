using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace AdventOfCode1016
{
    public class Day10
    {
        public string Input;
        public Dictionary<string, bool> Instructions = new Dictionary<string, bool>();
        public List<string> StartingInstructions = new List<string>();
        public Dictionary<int, Output> Outputs = new Dictionary<int, Output>();
        public Dictionary<int, Bot> Bots = new Dictionary<int, Bot>();
        public int LowerCompare;
        public int HigherCompare;

        public Day10(string input)
        {
            Input = input;
            ParseInstructions();
        }
        public Day10(string input, int lowerCompare, int higherCompare)
        {
            Input = input;
            ParseInstructions();
            LowerCompare = lowerCompare;
            HigherCompare = higherCompare;
        }

        private bool AreInstructionsCompleted ()
        {
            foreach (var bot in Bots.Values) {
                if (!bot.CanProceed)
                {
                    return false;
                }
            }
            return true;
        }

        public void InitializeBots ()
        {
            foreach (var instruction in StartingInstructions)
            {
                var botId = ParseBotNumber(instruction);
                var chip = ParseValue(instruction);
                if (Bots.Keys.Contains(botId)) {
                    Bots[botId].ReceiveChip(chip);
                } else {
                    var bot = new Bot(botId);
                    bot.ReceiveChip(chip);
                    Bots.Add(botId, bot);
                }
            }
        }

        public void RunInstructions ()
        {
            while (!CanAllBotProceed()) {

                // To optimize a little bit we do not run all instructions each time
                var tmpInstructions = new Dictionary<string, bool>();
                foreach (var instruction in Instructions)
                {
                    if (instruction.Value) {
                        continue;
                    }
                    tmpInstructions.Add(instruction.Key, false);

                    var givingBotId = ParseNumber(instruction.Key, "^bot");
                    if (!Bots.Keys.Contains(givingBotId)) {
                        var bot = new Bot(givingBotId);
                        Bots.Add(givingBotId, bot);
                    }
                    var givingBot = Bots[givingBotId];
                    if (!givingBot.CanProceed) { 
                        tmpInstructions[instruction.Key] = false;
                        continue; 
                    } else {
                        tmpInstructions[instruction.Key] = true;
                    }

                    var receivingLowerChipOutputId = ParseNumber(instruction.Key, "low to output");
                    var receivingHigherChipOutputId = ParseNumber(instruction.Key, "high to output");
                    var receivingLowerChipBotId = ParseNumber(instruction.Key, "low to bot");
                    var receivingHigherChipBotId = ParseNumber(instruction.Key, "high to bot");

                    // Lower, Bot
                    if (receivingLowerChipBotId >= 0) {
                        if (!Bots.Keys.Contains(receivingLowerChipBotId)) {
                            var bot = new Bot(receivingLowerChipBotId);
                            Bots.Add(receivingLowerChipBotId, bot);
                        }
                        givingBot.GiveLowerChip(Bots[receivingLowerChipBotId]);
                    }

                    // Lower, Output
                    if (receivingLowerChipOutputId >= 0) {
                        if (!Outputs.Keys.Contains(receivingLowerChipOutputId)) {
                            var output = new Output(receivingLowerChipOutputId);
                            Outputs.Add(receivingLowerChipOutputId, output);
                        }
                        givingBot.GiveLowerChip(Outputs[receivingLowerChipOutputId]);
                    }
                    
                    // Higher, Bot
                    if (receivingHigherChipBotId >= 0) {
                        if (!Bots.Keys.Contains(receivingHigherChipBotId)) {
                            var bot = new Bot(receivingHigherChipBotId);
                            Bots.Add(receivingHigherChipBotId, bot);
                        }
                        givingBot.GiveHigherChip(Bots[receivingHigherChipBotId]);
                    }
                    
                    // Higher, Output
                    if (receivingHigherChipOutputId >= 0) {
                        if (!Outputs.Keys.Contains(receivingHigherChipOutputId)) {
                            var output = new Output(receivingHigherChipOutputId);
                            Outputs.Add(receivingHigherChipOutputId, output);
                        }
                        givingBot.GiveHigherChip(Outputs[receivingHigherChipOutputId]);
                    }
                }
                Instructions = tmpInstructions;
            }
            
        }

        private bool CanAllBotProceed ()
        {
            foreach (var bot in Bots.Values) {
                if (!bot.CanProceed) {
                    return false;
                }
            }
            return true;
        }

        public Bot GetBotResponsibleToCompare ()
        {
            foreach (var bot in Bots.Values) {
                if (bot.LowerChip == LowerCompare && bot.HigherChip == HigherCompare) {
                    return bot;
                }
            }
            throw new Exception($"No bot was found who is responsible to compare chips {LowerCompare} and {HigherCompare}");
        }
        private void ParseInstructions ()
        {
        var lines = Input.Split('\n').Select(p => p.Trim()).ToList();
            foreach (var line in lines) {
                if (!String.IsNullOrEmpty(line)) {
                    if (line.Contains("value")) {
                        StartingInstructions.Add(line);
                    } else {
                        Instructions.Add(line, false);
                    }       
                }
            }
        }

        private int ParseBotNumber (string input) {
            return ParseNumber(input, "bot");
        }

        private int ParseValue (string input) {
            return ParseNumber(input, "value");
        }

        private int ParseNumber (string input, string lookFor)
        {
            var number = -1;
            var pattern = $"{lookFor} (?<number>[0-9]+)";
            var regex = new Regex(pattern);
            var match = regex.Match(input);
            if (match.Success)
            {
                Int32.TryParse(match.Groups["number"].Value, out number);
            }
            return number;
        }

    }

    public class Bot
    {
        public int Id;
        public string Name;
        public int Chip1 = 0;
        public int Chip2 = 0;

        public int LowerChip {
            get {
                if (Chip1 < Chip2) {
                    return Chip1;
                } else {
                    return Chip2;
                }
            }
            set {}
        }
        
        public int HigherChip {
            get {
                if (Chip1 > Chip2) {
                    return Chip1;
                } else {
                    return Chip2;
                }
            }
            set {}
        }

        public bool CanProceed {
            get {
                return (Chip2 > 0 && Chip1 > 0);
            }
            set {}
        }

        public Bot (int id) {
            Id = id;
            Name = $"Bot {Id}";
        }

        // We take the assumption you cannot 
        public void ReceiveChip (int i) {
            if (Chip1 == 0 && Chip2 == 0) {
                Chip1 = i;
            } else {
                if (Chip1 > 0 && Chip2 == 0) {
                    Chip2 = i;
                } else {
                    //throw new InvalidOperationException($"{Name} already contains two chips: {Chip1} and {Chip2}. Cannot add the chip {i}.");
                } 
            }
        }

        public void GiveLowerChip (Bot bot) {
            if (CanProceed) {
                bot.ReceiveChip(GiveLowerChip());
            }
        }

        public void GiveHigherChip (Bot bot) {
            if (CanProceed) {
                bot.ReceiveChip(GiveHigherChip());
            }

        }

        public void GiveLowerChip (Output output) {
            if (CanProceed) {
                output.ReceiveChip(GiveLowerChip(), this);
            }
        }

        public void GiveHigherChip (Output output) {
            if (CanProceed) {
                output.ReceiveChip(GiveHigherChip(), this);
            }
        }

        public int GiveLowerChip () {
            var give = LowerChip;
            /*if (Chip1 == LowerChip) {
                Chip1 = Chip2;
                
            }
            Chip2 = 0;*/
            return give;
        }

        public int GiveHigherChip () {
            var give = HigherChip;
            /*if (Chip1 == HigherChip) {
                Chip1 = Chip2;
                
            }
            Chip2 = 0;*/
            return give;
        }

    }

    public class Output
    {
        public int Id;
        public string Name;
        public int Chip;
        public Bot FromBot;

        public Output (int id) {
            Id = id;
            Name = $"Output {Id}";
        }

        // We take the assumption you cannot 
        public void ReceiveChip (int i, Bot bot) {
            Chip = i;
            FromBot = bot;
        }

    }
}
