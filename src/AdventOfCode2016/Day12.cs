using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace AdventOfCode1016
{
    public class Day12
    {
        public string Input;

        public Day12(string input)
        {
            Input = input;
        }

    }

    public class Computer {

        public Dictionary<int,string> Program = new Dictionary<int, string>();
        public ProgramCursor Cursor
        {
            get; private set;
        }
        private Dictionary<string, Instruction> instructions = new Dictionary<string, Instruction>();
        private Dictionary<string, Register> registers = new Dictionary<string, Register>();

        public int RegisterA
        {
            get { return registers["a"].Value;  }
            set { }
        }

        public int RegisterB
        {
            get { return registers["b"].Value; }
            set { }
        }

        public int RegisterC
        {
            get { return registers["c"].Value;  }
            set { }
        }

        public int RegisterD
        {
            get { return registers["d"].Value; }
            set { }
        }
       public Computer()
        {
            Initialize();
            registers["a"].Value = 0;
            registers["b"].Value = 0;
            registers["c"].Value = 0;
            registers["d"].Value = 0;
        }

        public Computer(int a = 0, int b = 0, int c = 0, int d = 0)
        {
            Initialize();
            registers["a"].Value = a;
            registers["b"].Value = b;
            registers["c"].Value = c;
            registers["d"].Value = d;
        }

        private void Initialize ()
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

            Cursor = new ProgramCursor();
        }

        public void LoadProgramFromString(string listing)
        {
            Program = new Dictionary<int, string>();
            int cpt = 0;
            var lines = listing.Split('\n').Select(p => p.Trim()).ToList();
            foreach (var programLine in lines)
            {
                if (!String.IsNullOrEmpty(programLine)) {
                    Program.Add(cpt++, programLine);
                }
            }
        }

        public void Reset()
        {
            registers["a"].Value = 0;
            registers["b"].Value = 0;
            registers["c"].Value = 0;
            registers["d"].Value = 0;
            Cursor.Position = 0;
        }

        public void Reset(int a = 0, int b = 0, int c = 0, int d = 0)
        {
            registers["a"].Value = a;
            registers["b"].Value = b;
            registers["c"].Value = c;
            registers["d"].Value = d;
            Cursor.Position = 0;
        }

        public void Run()
        {
            while (Program.ContainsKey(Cursor.Position)) {
                string[] programLine = Program[Cursor.Position].Split(' ');
                string code = programLine[0];
                string x = programLine[1];
                string y = (programLine.Length > 2) ? programLine[2] : String.Empty;
                instructions[code].Execute(registers, Cursor, x, y);
            }
        }
    }

    public class Register
    {
        public int Value { get; set; }
        public string Name { get; set; }
        public Register(string name)
        {
            Name = name;
            Value = 0;
        }
    }

    public class ProgramCursor
    {
        private int _position = 0;
        public int Position { 
            get {
                return _position;
            } 
            set {
                if (value < 0) {
                    _position = 0;
                } else {
                    _position = value;
                }
            }
         }
    }

    public abstract class Instruction
    {
        public string Name;
        public string Help;
        public string Code;
        public abstract void Execute(Dictionary<string, Register> registers, ProgramCursor cursor, string x, string y);
    }

    public class Instruction_INC : Instruction
    {
        public Instruction_INC()
        {
            Name = "Increment";
            Help = "Increments register x, adding 1 to it, then continues with the next instruction.";
            Code = "inc";
        }
        public override void Execute(Dictionary<string, Register> registers, ProgramCursor cursor, string x, string y = "")
        {
            registers[x].Value++;
            cursor.Position++;
        }
    }

    public class Instruction_DEC : Instruction
    {
        public Instruction_DEC()
        {
            Name = "Decrement";
            Help = "Decrements register x, substracting 1 to it, then continues with the next instruction.";
            Code = "dec";
        }
        public override void Execute(Dictionary<string, Register> registers, ProgramCursor cursor, string x, string y = "")
        {
            registers[x].Value--;
            cursor.Position++;
        }
    }

    public class Instruction_JNZ : Instruction
    {
        public Instruction_JNZ()
        {
            Name = "Jump";
            Help = "Jumps to an instruction y away (positive means forward; negative means backward), but only if x is not zero.";
            Code = "jnz";
        }
        public override void Execute(Dictionary<string, Register> registers, ProgramCursor cursor, string x, string y)
        {
            bool goToNextInstruction = false;
            Regex regex = new Regex(@"([0-9]+)");
            Match match = regex.Match(x);
            if (match.Success)
            {
                 var value = 0;
                 Int32.TryParse(match.Groups[1].Value, out value);
                 if (value == 0) {
                    goToNextInstruction = true;
                 }
            } else {
                if (registers[x].Value == 0) {
                    goToNextInstruction = true;
                }
            }

            var offset = 0;
            if (goToNextInstruction) {
                cursor.Position++;
            } else {
                Int32.TryParse(y, out offset);
                cursor.Position += offset;
            }
        }
    }

    public class Instruction_CPY : Instruction
    {
        public Instruction_CPY()
        {
            Name = "Copy";
            Help = "Copies x (either an integer or the value of a register) into register y";
            Code = "CPY";
        }
        public override void Execute(Dictionary<string, Register> registers, ProgramCursor cursor, string x, string y)
        {
            Regex regex = new Regex(@"([0-9]+)");
            Match match = regex.Match(x);
            if (match.Success)
            {
                 var value = 0;
                 Int32.TryParse(match.Groups[1].Value, out value);
                 registers[y].Value = value;
            } else {
                registers[y].Value = registers[x].Value;
            }
            cursor.Position++;    
        }
    }
}