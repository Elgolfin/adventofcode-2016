using System;
using Xunit;
using AdventOfCode1016;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode1016Tests
{
    public class Day04UnitTests
    {
        
        [Fact]
        public void Should_Instanciate_Room_Properly_1() 
        {
            var input = "aaaaa-bbb-z-y-x-123[abxyz]";
            var room = new Room(input);
            Assert.Equal("aaaaa-bbb-z-y-x", room.EncryptedName);
            Assert.Equal(123, room.SectorId);
            Assert.Equal("abxyz", room.Checksum);
        }

        [Fact]
        public void Room_1_Should_Be_A_Real_Room() 
        {
            var input = "aaaaa-bbb-z-y-x-123[abxyz]";
            var room = new Room(input);
            Assert.Equal(true, room.IsRealRoom());
        }

        [Fact]
        public void Room_1_Checksum_Should_Be_abxyz() 
        {
            var input = "aaaaa-bbb-z-y-x-123[abxyz]";
            var room = new Room(input);
            Assert.Equal("abxyz", room.CalculateChecksum());
        }

        [Fact]
        public void Should_Instanciate_Room_Properly_2() 
        {
            var input = "a-b-c-d-e-f-g-h-987[abcde]";
            var room = new Room(input);
            Assert.Equal("a-b-c-d-e-f-g-h", room.EncryptedName);
            Assert.Equal(987, room.SectorId);
            Assert.Equal("abcde", room.Checksum);
        }

        [Fact]
        public void Room_2_Checksum_Should_Be_abcde() 
        {
            var input = "a-b-c-d-e-f-g-h-987[abcde]";
            var room = new Room(input);
            Assert.Equal("abcde", room.CalculateChecksum());
        }

        [Fact]
        public void Room_2_Bis_Checksum_Should_Be_bacde() 
        {
            var input = "b-b-c-d-e-f-g-a-987[bacde]";
            var room = new Room(input);
            Assert.Equal("bacde", room.CalculateChecksum());
        }

        [Fact]
        public void Room_2_Should_Be_A_Real_Room() 
        {
            var input = "a-b-c-d-e-f-g-h-987[abcde]";
            var room = new Room(input);
            Assert.Equal(true, room.IsRealRoom());
        }

        [Fact]
        public void Should_Instanciate_Room_Properly_3() 
        {
            var input = "not-a-real-room-404[oarel]";
            var room = new Room(input);
            Assert.Equal("not-a-real-room", room.EncryptedName);
            Assert.Equal(404, room.SectorId);
            Assert.Equal("oarel", room.Checksum);
        }

        [Fact]
        public void Room_3_Should_Be_A_Real_Room() 
        {
            var input = "not-a-real-room-404[oarel]";
            var room = new Room(input);
            Assert.Equal(true, room.IsRealRoom());
        }

        [Fact]
        public void Should_Instanciate_Room_Properly_4() 
        {
            var input = "totally-real-room-200[decoy]";
            var room = new Room(input);
            Assert.Equal("totally-real-room", room.EncryptedName);
            Assert.Equal(200, room.SectorId);
            Assert.Equal("decoy", room.Checksum);
        }

        [Fact]
        public void Room_4_Should_Not_Be_A_Real_Room() 
        {
            var input = "totally-real-room-200[decoy]";
            var room = new Room(input);
            Assert.Equal(false, room.IsRealRoom());
        }

        [Fact]
        public void Sum_Of_Rooms_SectorId_Should_Return_1514() 
        {
            var input = @"aaaaa-bbb-z-y-x-123[abxyz]
a-b-c-d-e-f-g-h-987[abcde]
not-a-real-room-404[oarel]
totally-real-room-200[decoy]";
            var d04 = new Day04(input);
            Assert.Equal(1514, d04.SectorIdSum);
        }

        [Fact]
        public void Decrypt_Name_abcde_With_SectorId_1_Should_Return_bcdef() 
        {
            var input = "abcde-1[abcde]";
            var room = new Room(input);
            Assert.Equal("bcdef", room.Name);
        }
        
        [Fact]
        public void Decrypt_Name_zzabcd_With_SectorId_1_Should_Return_aabcde() 
        {
            var input = "zzabcd-1[zabcd]";
            var room = new Room(input);
            Assert.Equal("aabcde", room.Name);
        }
        
        [Fact]
        public void Decrypt_Name_qzmt_zixmtkozy_ivhz_With_SectorId_343_Should_Return_very_encrypted_name() 
        {
            //           very encrypted name
            var input = "qzmt-zixmtkozy-ivhz-343[zimth]";
            var room = new Room(input);
            Assert.Equal("zimth", room.Checksum);
            Assert.Equal("very encrypted name", room.Name);
        }

    }
}
