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
            Assert.Equal("node-y1-x0", n.Name);
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

        [Fact]
        public void Get_Empty_Node_Should_Return_Node_0_2()
        {
            var input = @"root@ebhq-gridcenter# df -h
Filesystem              Size  Used  Avail  Use%
/dev/grid/node-x0-y0     93T   67T    26T   72%
/dev/grid/node-x0-y1     89T   70T    19T   78%
/dev/grid/node-x0-y2     89T   0T    89T   0%";

            var d22 = new Day22(input);
            Assert.Equal("0,2", d22.GetEmptyNode().Id);
        }

        [Fact]
        public void Find_Shortest_Path_From_3_0_To_0_0_Should_Return_A_Direct_Path()
        {
            var input = @"root@ebhq-gridcenter# df -h
Filesystem              Size  Used  Avail  Use%
/dev/grid/node-x0-y0     93T   67T    26T   72%
/dev/grid/node-x0-y1     88T   68T    20T   78%
/dev/grid/node-x0-y2     93T   64T    29T   68%
/dev/grid/node-x0-y3     92T   66T    26T   71%
/dev/grid/node-x1-y0     90T   71T    19T   78%
/dev/grid/node-x1-y1     85T   73T    12T   85%
/dev/grid/node-x1-y2     88T   70T    18T   79%
/dev/grid/node-x1-y3     94T   70T    24T   74%
/dev/grid/node-x2-y0     94T   73T    21T   77%
/dev/grid/node-x2-y1     93T   65T    28T   69%
/dev/grid/node-x2-y2     86T   68T    18T   79%
/dev/grid/node-x2-y3     86T   65T    21T   75%
/dev/grid/node-x3-y0     94T   73T    21T   77%
/dev/grid/node-x3-y1     93T   65T    28T   69%
/dev/grid/node-x3-y2     86T   68T    18T   79%
/dev/grid/node-x3-y3     86T   65T    21T   75%";

            var d22 = new Day22(input);
            Assert.Equal("3,0|2,0|1,0|0,0", d22.FindShortestPath(d22.Grid["3,0"], d22.Grid["0,0"]));
            //Assert.Equal(3, d22.FindShortestPath(d22.Grid["3,0"], d22.Grid["0,0"]));
        }

        [Fact]
        public void Find_Shortest_Path_From_3_0_To_0_0_Should_Return_Right_Path()
        {
            var input = @"root@ebhq-gridcenter# df -h
Filesystem              Size  Used  Avail  Use%
/dev/grid/node-x0-y0     93T   67T    26T   72%
/dev/grid/node-x0-y1     90T   71T    19T   78%
/dev/grid/node-x0-y2     93T   64T    29T   68%
/dev/grid/node-x0-y3     92T   66T    26T   71%
/dev/grid/node-x1-y0     589T 588T     1T   78%
/dev/grid/node-x1-y1     85T   73T    12T   85%
/dev/grid/node-x1-y2     88T   70T    18T   79%
/dev/grid/node-x1-y3     94T   70T    24T   74%
/dev/grid/node-x2-y0     94T   73T    21T   77%
/dev/grid/node-x2-y1     93T   65T    28T   69%
/dev/grid/node-x2-y2     86T   68T    18T   79%
/dev/grid/node-x2-y3     86T   65T    21T   75%
/dev/grid/node-x3-y0     94T   73T    21T   77%
/dev/grid/node-x3-y1     93T   65T    28T   69%
/dev/grid/node-x3-y2     86T   68T    18T   79%
/dev/grid/node-x3-y3     86T   65T    21T   75%";

            var d22 = new Day22(input);
            Assert.Equal("3,0|2,0|2,1|1,1|0,1|0,0", d22.FindShortestPath(d22.Grid["3,0"], d22.Grid["0,0"]));
            //Assert.Equal(5, d22.FindShortestPath(d22.Grid["3,0"], d22.Grid["0,0"]));
        }

        [Fact]
        public void Find_Number_Of_Steps_To_Move_Data_Should_Return_7()
        {
            var input = @"Filesystem            Size  Used  Avail  Use%
/dev/grid/node-x0-y0   10T    8T     2T   80%
/dev/grid/node-x0-y1   11T    6T     5T   54%
/dev/grid/node-x0-y2   532T   528T     4T   87%
/dev/grid/node-x1-y0    9T    7T     2T   77%
/dev/grid/node-x1-y1    8T    0T     8T    0%
/dev/grid/node-x1-y2   11T    7T     4T   63%
/dev/grid/node-x2-y0   10T    6T     4T   60%
/dev/grid/node-x2-y1    9T    8T     1T   88%
/dev/grid/node-x2-y2    9T    6T     3T   66%";

            var d22 = new Day22(input);
            Assert.Equal(7, d22.MoveData("2,0"));
        }
    }



    
}
