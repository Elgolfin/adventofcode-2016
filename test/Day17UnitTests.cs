using System;
using Xunit;
using AdventOfCode1016;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode1016Tests
{
    public class Day17UnitTests
    {
        [Fact]
        public void Current_VaultRoom_With_Passcode_hijkl_Should_Return_Down_Only() 
        {
            var room = new VaultRoom(0, 0, new Vault(4, 4));
            room.SetPasscode("hijkl");
            Assert.Equal(true, room.IsPathToDownOpened);
            Assert.Equal(false, room.IsPathToUpOpened);
            Assert.Equal(false, room.IsPathToRightOpened);
            Assert.Equal(false, room.IsPathToLeftOpened);
            var rooms = room.GetNextAvailableRooms();
            Assert.Equal(1, rooms.Count);
        }

        [Fact]
        public void Current_VaultRoom_With_Passcode_hijklD_Should_Return_Up_And_Right() 
        {
            var room = new VaultRoom(0, 1, new Vault(4, 4));
            room.SetPasscode("hijklD");
            Assert.Equal(false, room.IsPathToDownOpened);
            Assert.Equal(true, room.IsPathToUpOpened);
            Assert.Equal(true, room.IsPathToRightOpened);
            Assert.Equal(false, room.IsPathToLeftOpened);
            var rooms = room.GetNextAvailableRooms();
            Assert.Equal(2, rooms.Count);
        }

        [Fact]
        public void Current_VaultRoom_With_Passcode_hijklDR_Should_Return_No_Available_Path() 
        {
            var room = new VaultRoom(1, 1, new Vault(4, 4));
            room.SetPasscode("hijklDR");
            Assert.Equal(false, room.IsPathToDownOpened);
            Assert.Equal(false, room.IsPathToUpOpened);
            Assert.Equal(false, room.IsPathToRightOpened);
            Assert.Equal(false, room.IsPathToLeftOpened);
            var rooms = room.GetNextAvailableRooms();
            Assert.Equal(0, rooms.Count);
        }

        [Fact]
        public void Current_VaultRoom_With_Passcode_hijklDU_Should_Return_Right_Only() 
        {
            var room = new VaultRoom(0, 0, new Vault(4, 4));
            room.SetPasscode("hijklDU");
            Assert.Equal(false, room.IsPathToDownOpened);
            Assert.Equal(false, room.IsPathToUpOpened);
            Assert.Equal(true, room.IsPathToRightOpened);
            Assert.Equal(false, room.IsPathToLeftOpened);
            var rooms = room.GetNextAvailableRooms();
            Assert.Equal(1, rooms.Count);
        }

        [Fact]
        public void Current_VaultRoom_With_Passcode_hijklDUR_Should_Return_No_Available_Path() 
        {
            var room = new VaultRoom(1, 0, new Vault(4, 4));
            room.SetPasscode("hijklDUR");
            Assert.Equal(false, room.IsPathToDownOpened);
            Assert.Equal(false, room.IsPathToUpOpened);
            Assert.Equal(false, room.IsPathToRightOpened);
            Assert.Equal(false, room.IsPathToLeftOpened);
            var rooms = room.GetNextAvailableRooms();
            Assert.Equal(0, rooms.Count);
        }

        [Fact]
        public void Current_VaultRoom_With_Passcode_ihgpwlahDDR_Should_Return_All_Paths_As_Available() 
        {
            var room = new VaultRoom(1, 2, new Vault(4, 4));
            room.SetPasscode("ihgpwlahDDR");
            Assert.Equal(true, room.IsPathToDownOpened);
            Assert.Equal(true, room.IsPathToUpOpened);
            Assert.Equal(true, room.IsPathToRightOpened);
            Assert.Equal(true, room.IsPathToLeftOpened);
            var rooms = room.GetNextAvailableRooms();
            Assert.Equal(4, rooms.Count);
        }

        [Fact]
        public void Initialize_Default_Vault_Should_Return_16_Rooms() 
        {
            var vault = new Vault();
            Assert.Equal(16, vault.Rooms.Count);
        }
        
        [Theory]
        [InlineData("ihgpwlah", "DDRRRD")]
        [InlineData("kglvqrro", "DDUDRLRRUDRD")]
        [InlineData("ulqzkmiv", "DRURDRUDDLLDLUURRDULRLDUUDDDRR")]
        public void Find_The_Shortest_Path_Should_Return_The_Right_Path(string passcode, string expectedPath) 
        {
            var d17 = new Day17(passcode);
            Assert.Equal(expectedPath, d17.FindPathToExit());
        }
        
    }
}
