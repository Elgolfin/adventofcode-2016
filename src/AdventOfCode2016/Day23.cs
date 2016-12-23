using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace AdventOfCode1016
{
    public class Day23
    {
        public string Input;
        

        public Day23(string input)
        {
            Input = input;
            ParseLines();
        }

        private void ParseLines () {
            var lines = Input.Split('\n').Select(p => p.Trim()).ToList();
            foreach (var line in lines) {
                if (!String.IsNullOrEmpty(line)) {
                    
                }
            }
            

        }
    }

    public class Computerv2 : Computer {
        public Dictionary<int,string> toggledInstructions = new Dictionary<int, string>();

        public Computerv2(int a = 0, int b = 0, int c = 0, int d = 0) : base(a, b, c, d)
        {}

        protected override void Initialize ()
        {
            // Should use depedency injection to inject a collection of registers to the computer class
            registers.Add("a", new Register("a"));
            registers.Add("b", new Register("b"));
            registers.Add("c", new Register("c"));
            registers.Add("d", new Register("d"));
            // Should use depedency injection to inject a set of instructions to the computer class
            // So when we would like to add a new instruction to the computer, no need to modify the Computer class
            instructions.Add("inc", new Instruction_INC());
            instructions.Add("dec", new Instruction_DEC());
            instructions.Add("cpy", new Instruction_CPY());
            instructions.Add("jnz", new Instruction_JNZ());
            instructions.Add("tgl", new Instruction_TGL());

            Cursor = new ProgramCursor();
        }

        public override void Run()
        {
            while (Program.ContainsKey(Cursor.Position)) {
                string[] programLine = Program[Cursor.Position].Split(' ');
                string code = programLine[0];
                string x = programLine[1];
                string y = (programLine.Length > 2) ? programLine[2] : String.Empty;
                if (code == "tgl") {
                    instructions[code].Execute(registers, Program, Cursor, x, y);
                } else {
                    instructions[code].Execute(registers, Cursor, x, y);
                }
            }
        }
    }

    public class Instruction_TGL : Instruction
    {
        public Instruction_TGL()
        {
            Name = "Toggle";
            Help = @"tgl x toggles the instruction x away (pointing at instructions like jnz does: positive means forward; negative means backward):

    For one-argument instructions, inc becomes dec, and all other one-argument instructions become inc.
    For two-argument instructions, jnz becomes cpy, and all other two-instructions become jnz.
    The arguments of a toggled instruction are not affected.
    If an attempt is made to toggle an instruction outside the program, nothing happens.
    If toggling produces an invalid instruction (like cpy 1 2) and an attempt is later made to execute that instruction, skip it instead.
    If tgl toggles itself (for example, if a is 0, tgl a would target itself and become inc a), the resulting instruction is not executed until the next time it is reached.";
            Code = "tgl";
        }

        public override void Execute(Dictionary<string, Register> registers, ProgramCursor cursor, string x, string y = "") {

        }

        public override void Execute(Dictionary<string, Register> registers, Dictionary<int,string> program, ProgramCursor cursor, string x, string y = "")
        {
            
            Regex regex = new Regex(@"(-?[0-9]+)");
            Match match = regex.Match(x);
            var argValue = 0;
            if (match.Success)
            {
                 Int32.TryParse(match.Groups[1].Value, out argValue);
            } else {
                argValue = registers[x].Value;
            }

            // Change the instruction at line cursor + argValue
            ToggleInstruction(cursor.Position + argValue, program, registers);

            cursor.Position++;
        }

        private void ToggleInstruction (int numLine, Dictionary<int,string> program, Dictionary<string, Register> registers)
        {
            // If an attempt is made to toggle an instruction outside the program, nothing happens.
            if (!program.ContainsKey(numLine)) {
                return;
            }
            
            var instructionToToggle = program[numLine];            
            
            var numArg = instructionToToggle.Split(' ').Count() - 1;
            // One argument (includes toggle itself)
            if (numArg == 1) {
                if (instructionToToggle.Contains("inc")) {
                    instructionToToggle = instructionToToggle.Replace("inc", "dec");
                } else {
                    instructionToToggle = instructionToToggle.Replace(instructionToToggle.Substring(0, 3), "inc");
                }
            }

            // Two arguments
            if (numArg == 2) {
                if (instructionToToggle.Contains("jnz")) {
                    instructionToToggle = instructionToToggle.Replace("jnz", "cpy");
                } else {
                    /*
                    var strX = instructionToToggle.Split(' ')[1];
                    var x = 0;
                    if (char.IsLetter(strX[0])) {
                        x = registers[strX].Value;
                    } else {
                        Int32.TryParse(strX, out x);
                    }
                    */
                    var strY = instructionToToggle.Split(' ')[2];
                    var y = 0;
                    if (char.IsLetter(strY[0])) {
                        y = registers[strY].Value;
                    } else {
                        Int32.TryParse(strY, out y);
                    }
                    //if (strY)
                    instructionToToggle = instructionToToggle.Replace(instructionToToggle.Substring(0, 3), "jnz");
                }
            }

            program[numLine] = instructionToToggle;
        }
    }
}
