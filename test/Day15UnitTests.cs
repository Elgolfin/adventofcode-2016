using System;
using Xunit;
using AdventOfCode1016;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode1016Tests
{
    public class Day15UnitTests
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
        public void Disc_With_5_Positions_Starting_At_Position_0_Should_Return_1_As_Next_Position() 
        {
            var d = new Disc(5, 0);
            d.MoveNext();
            Assert.Equal(1, d.CurrentPosition);
        }

        [Fact]
        public void Disc_With_1_Position_Starting_At_Position_0_Should_Return_0_As_Next_Position() 
        {
            var d = new Disc(1, 0);
            d.MoveNext();
            Assert.Equal(0, d.CurrentPosition);
        }

        [Fact]
        public void Disc_With_5_Positions_Starting_At_Position_0_Should_Return_0_If_Moved_5_Times() 
        {
            var d = new Disc(5, 0);
            d.MoveNext(5);
            Assert.Equal(0, d.CurrentPosition);
        }

        [Fact]
        public void Disc_With_5_Positions_Starting_At_Position_0_Should_Return_1_If_Moved_6_Times() 
        {
            var d = new Disc(5, 0);
            d.MoveNext(6);
            Assert.Equal(1, d.CurrentPosition);
        }

        [Fact]
        public void Disc_With_5_Positions_Starting_At_Position_0_Should_Return_1_If_Simulate_Moved_6_Times() 
        {
            var d = new Disc(5, 0);
            Assert.Equal(1, d.SimulateMoveNext(6));
        }

        [Fact]
        public void Disc_With_5_Position_Starting_At_Position_5_Should_Return_0_As_Current_Position() 
        {
            var d = new Disc(5, 5);
            Assert.Equal(0, d.CurrentPosition);
        }

        [Fact]
        public void Disc_With_5_Positions_Starting_At_Position_4_Should_Return_0_As_Next_Position() 
        {
            var d = new Disc(5, 4);
            d.MoveNext();
            Assert.Equal(0, d.CurrentPosition);
        }

        [Fact]
        public void Initialise_Day15_With_2_Discs_Should_Return_A_List_Of_2_Discs () {
            var d15 = new Day15(new List<Disc>() {
                new Disc(5, 4),
                new Disc(2, 1)
            });
            Assert.Equal(2, d15.Discs.Count);
        }

        [Fact]
        public void At_Time_1_Discs_Should_Respectively_Return_Position_0_And_0 () {
            var d15 = new Day15(new List<Disc>() {
                new Disc(5, 4),
                new Disc(2, 1)
            });
            d15.NextTick();
            Assert.Equal(0, d15.Discs[0].CurrentPosition);
            Assert.Equal(0, d15.Discs[1].CurrentPosition);
        }

        [Fact]
        public void At_Time_2_Discs_Should_Respectively_Return_Position_1_And_1 () {
            var d15 = new Day15(new List<Disc>() {
                new Disc(5, 4),
                new Disc(2, 1)
            });
            d15.NextTick();
            d15.NextTick();
            Assert.Equal(1, d15.Discs[0].CurrentPosition);
            Assert.Equal(1, d15.Discs[1].CurrentPosition);
        }

        [Fact]
        public void At_Time_1_Pushing_The_Button_Will_Not_Make_The_Capsule_Fall_Through () {
            var d15 = new Day15(new List<Disc>() {
                new Disc(5, 4),
                new Disc(2, 1)
            });
            d15.NextTick();
            Assert.Equal(false, d15.AreAllSlotsWillBeAlignedInSequence());
        }

        [Fact]
        public void At_Time_2_Pushing_The_Button_Will_Not_Make_The_Capsule_Fall_Through () {
            var d15 = new Day15(new List<Disc>() {
                new Disc(5, 4),
                new Disc(2, 1)
            });
            d15.NextTick();
            d15.NextTick();
            Assert.Equal(false, d15.AreAllSlotsWillBeAlignedInSequence());
        }

        [Fact]
        public void At_Time_3_Pushing_The_Button_Will_Not_Make_The_Capsule_Fall_Through () {
            var d15 = new Day15(new List<Disc>() {
                new Disc(5, 4),
                new Disc(2, 1)
            });
            d15.NextTick();
            d15.NextTick();
            d15.NextTick();
            Assert.Equal(false, d15.AreAllSlotsWillBeAlignedInSequence());
        }

        [Fact]
        public void At_Time_4_Pushing_The_Button_Will_Not_Make_The_Capsule_Fall_Through () {
            var d15 = new Day15(new List<Disc>() {
                new Disc(5, 4),
                new Disc(2, 1)
            });
            d15.NextTick();
            d15.NextTick();
            d15.NextTick();
            d15.NextTick();
            Assert.Equal(false, d15.AreAllSlotsWillBeAlignedInSequence());
        }

        [Fact]
        public void At_Time_5_Pushing_The_Button_Will_Make_The_Capsule_Fall_Through () {
            var d15 = new Day15(new List<Disc>() {
                new Disc(5, 4),
                new Disc(2, 1)
            });
            d15.NextTick();
            d15.NextTick();
            d15.NextTick();
            d15.NextTick();
            d15.NextTick();
            Assert.Equal(true, d15.AreAllSlotsWillBeAlignedInSequence());
        }

        [Fact]
        public void Pushing_The_Button_To_Fall_The_Capsule_Through_Should_Return_Time_5 () {
            var d15 = new Day15(new List<Disc>() {
                new Disc(5, 4),
                new Disc(2, 1)
            });
            Assert.Equal(5, d15.PushButtonToFallThrough());
        }

    }
}
