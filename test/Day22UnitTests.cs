using System;
using Xunit;
using AdventOfCode1016;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode1016Tests
{
    public class Day22UnitTests
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
        public void Initialize_Node_With_Input_Should_Return_Proper_Node() 
        {
            var n = new Node("/dev/grid/node-x0-y1     93T   67T    26T   72%");
            Assert.Equal("0,1", n.Id);
            Assert.Equal("node-x0-y1", n.Name);
            Assert.Equal(0, n.X);
            Assert.Equal(1, n.Y);
            Assert.Equal(93, n.Size);
            Assert.Equal(67, n.Used);
            Assert.Equal(26, n.Available);
            Assert.Equal("/dev/grid/node-x0-y1  93T  67T  26T", n.ToString());
        }

        [Fact]
        public void Initialize_Grid_Should_Return_A_Grid_Of_12_Nodes()
        {
            var input = @"root@ebhq-gridcenter# df -h
Filesystem              Size  Used  Avail  Use%
/dev/grid/node-x0-y0     93T   67T    26T   72%
/dev/grid/node-x0-y1     89T   70T    19T   78%
/dev/grid/node-x0-y2     93T   64T    29T   68%
/dev/grid/node-x0-y3     92T   66T    26T   71%
/dev/grid/node-x1-y0     90T   71T    19T   78%
/dev/grid/node-x1-y1     85T   73T    12T   85%
/dev/grid/node-x1-y2     88T   70T    18T   79%
/dev/grid/node-x1-y3     94T   70T    24T   74%
/dev/grid/node-x2-y0     94T   73T    21T   77%
/dev/grid/node-x2-y1     93T   65T    28T   69%
/dev/grid/node-x2-y2     86T   68T    18T   79%
/dev/grid/node-x2-y3     86T   65T    21T   75%";

            var d22 = new Day22(input);
            Assert.Equal(12, d22.Grid.Count);
        }

        [Fact]
        public void Initialize_Grid_Should_Return_A_4_Viable_Pairs()
        {
            var input = @"root@ebhq-gridcenter# df -h
Filesystem              Size  Used  Avail  Use%
/dev/grid/node-x0-y0     93T   67T    26T   72%
/dev/grid/node-x0-y1     89T   70T    19T   78%
/dev/grid/node-x0-y2     89T   1T    88T   78%";

            var d22 = new Day22(input);
            Assert.Equal(4, d22.ViablePairs.Count);
        }

    }
}
