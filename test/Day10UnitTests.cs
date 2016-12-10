using System;
using Xunit;
using AdventOfCode1016;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode1016Tests
{
    public class Day10UnitTests
    {
        /*
        [Theory]
        [InlineData("abba")]
        [InlineData("abba[mnop]qrst")] // abba[mnop]qrst supports TLS (abba outside square brackets).
        [InlineData("ioxxoj[asdfgh]zxcvbn")] // ioxxoj[asdfgh]zxcvbn supports TLS (oxxo is outside square brackets, even though it's within a larger string).
        [InlineData("rxpusykufgqujfe[rypwoorxdemxffui]cvvcufcqmxoxcphp[witynplrfvquduiot]vcysdcsowcxhphp[gctucefriclxaonpwe]jdprpdvpeumrhokrcjt")]
        public void Has_ABBA_Input_Should_Return_True(string input) 
        {
            Assert.Equal(true, Day07.HasABBA(input));
        }
        */

        [Fact]
        public void Parse_Instructions_Should_Return_2_Starting_Instructions_And_3_Others() 
        {
            var input = @"value 5 goes to bot 2
bot 2 gives low to bot 1 and high to bot 0
value 3 goes to bot 1
bot 1 gives low to output 1 and high to bot 0
bot 0 gives low to output 2 and high to output 0
value 2 goes to bot 2
";
            var d = new Day10(input);
            Assert.Equal(3, d.StartingInstructions.Count);
            Assert.Equal(3, d.Instructions.Count);
        }

        [Fact]
        public void Initialize_Bot_Should_Return_Properties_Properly_Set() 
        {
            var bot = new Bot(1);

            Assert.Equal("Bot 1", bot.Name);
            Assert.Equal(1, bot.Id);
            Assert.Equal(0, bot.Chip1);
            Assert.Equal(0, bot.Chip2);
        }

        [Fact]
        public void Bot_Receiving_Chips_1_And_2_Should_Have_Chip1_Set_To_1_And_Chip2_Set_To_2() 
        {
            var bot = new Bot(1);

            bot.ReceiveChip(1);
            Assert.Equal(1, bot.Chip1);
            Assert.Equal(0, bot.Chip2);

            bot.ReceiveChip(2);
            Assert.Equal(1, bot.Chip1);
            Assert.Equal(2, bot.Chip2);           
        }

        [Fact]
        public void Bot_Receiving_Chips_9_And_2_Should_Return_LowerChip_Set_To_2_And_HigherChip_Set_To_9() 
        {
            var bot = new Bot(1);

            bot.ReceiveChip(9);
            bot.ReceiveChip(2);
            Assert.Equal(9, bot.Chip1);
            Assert.Equal(2, bot.Chip2);
            Assert.Equal(2, bot.LowerChip);
            Assert.Equal(9, bot.HigherChip); 
        }

        [Fact]
        public void Initialize_Day10_Should_Return_A_List_Of_2_Bots() 
        {
            var input = @"value 5 goes to bot 2
bot 2 gives low to bot 1 and high to bot 0
value 3 goes to bot 1
bot 1 gives low to output 1 and high to bot 0
bot 0 gives low to output 2 and high to output 0
value 2 goes to bot 2
";
            var d = new Day10(input);
            d.InitializeBots();
            Assert.Equal(2, d.Bots.Count);
            Assert.Equal(2, d.Bots[2].LowerChip);
            Assert.Equal(5, d.Bots[2].HigherChip);
            Assert.Equal(3, d.Bots[1].HigherChip);
        }

        [Fact]
        public void RunInstructions_Day10_Should_Return_Proper_Values() 
        {
            var input = @"value 5 goes to bot 2
bot 2 gives low to bot 1 and high to bot 0
value 3 goes to bot 1
bot 1 gives low to output 1 and high to bot 0
bot 0 gives low to output 2 and high to output 0
value 2 goes to bot 2
";
            var d = new Day10(input);
            d.InitializeBots();
            d.RunInstructions();
            d.InitializeBots();
            Assert.Equal(3, d.Bots.Count);
            Assert.Equal(2, d.Bots[2].LowerChip);
            Assert.Equal(5, d.Bots[2].HigherChip);
            Assert.Equal(3, d.Bots[1].HigherChip);
            Assert.Equal(2, d.Bots[1].LowerChip);
            Assert.Equal(5, d.Bots[0].HigherChip);
            Assert.Equal(3, d.Bots[0].LowerChip);
        }

        [Fact]
        public void RunInstructions_Day10_Should_Return_Bot_2_As_Responsible_To_Compare() 
        {
            var input = @"value 5 goes to bot 2
bot 2 gives low to bot 1 and high to bot 0
value 3 goes to bot 1
bot 1 gives low to output 1 and high to bot 0
bot 0 gives low to output 2 and high to output 0
value 2 goes to bot 2
";
            var d = new Day10(input, 2, 5);
            d.InitializeBots();
            d.RunInstructions();
            Assert.Equal(2, d.GetBotResponsibleToCompare().Id);

        }

    }
}
