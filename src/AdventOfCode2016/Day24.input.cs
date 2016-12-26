﻿

namespace AdventOfCode1016
{
    public static class Day24Input
    {
        public static string Data = @"
#####################################################################################################################################################################################
#.....#...#.#...............#...........#.......#.#...#.......#...#.......#.....#.............#.........#...#.........#.......#.#.#4....#.....#...#.......#.........#.#.....#.......#
###.###.#.#.###.###.#.#####.#.###.#.###.#.#.#.#.#.#.#.###.###.#.#.#.###.#.#.###.#.###.#.#.#######.#.#.#.###.#.#.#.###.#.#####.#.#.###.###.#.###.#.###.#.#.#.###.###.#.#.#.#.#.#.#.###
#...#.....#.....#...#.......#.#.#.#.#...#.....#.#...#.....#...#...#.#...#.#.......#.....#.#.........#...#.#.#...#...#.........#...#.......#.#...#.........#.#...#...#.#.#.#.....#...#
#.###.###.#.#.#.#.#######.#.#.#.#.#.###.#.#.###.#.###.#.###.#.#.#.#########.###.#.#.#.###.###.#.###.###.#.#.#.#.#####.#.###.#.#.###.#.#.#.#.###.###.#.#####.#.#####.#.###.#.###.#.#.#
#.#.....#.#.....#.....#...#.....#.#...#...#.#.......#.#.#.....#.......#...#...#.#.#.#.....#...#.#.#.....#...#.#.#...........#...#...#.#.#.....#...........#.#.#.......#.............#
#.#####.#####.#.#####.#.#.#.###.#.#.#.#.#.#####.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.###.#.###.#.#.#.###.#.#.#.###.#.#.#.###.#.#.###########.#.###.#.#.#.#.#.#.#.#####.#.###.#.#####.###.#.#
#...#.....#.......#.#.#.#...#...#...#.#.#.......#.....#.........#.#...........#.#.........#.#.....................#.......#.....#.............#.........#.....#.....#...#.#.#.......#
#.###.#.#.#.#.#.#.#.###.#.#.#.#.#.#.#.#####.#####.#.###.#.#.###.#.#####.###.#.#.#.#######.#.#.#######.#.#.###.#.#.#.#######.###.###.###.#######.#.#####.#.#.#.#.###.###.#.#.#######.#
#...............#...#.#6..#...#...#...#...#.........#...#.#.....#.....#...#.#.....#.......#...#.#.....#...#.....#.........#...........#.#...........#...#0..#.............#.#...#...#
#.#.#####.#########.#.#####.#.#.#######.#.#.#.#.###.###.#.###.#.#####.#.#.#.#########.#.#######.#.#.#.#.#.#.#.#.#.###.###.#.#.#######.###.#########.#.#.###.#.#.#.#.#.###.#.#.###.#.#
#.#.....#.#.#...#.....#.....#...#.............#...#.......#...#...#...#.#.#.....#.#...#.......#.#...#.......#.#...#...#.......#.....#...#...#...#.#...#.....#.#...#...#.#...#.#...#.#
#.###.#.###.#.#.#.###.###.#.###.#.#.###.#####.#####.#.#####.###.#.#######.###.#.#.#########.###.#.#.#.###.#.#.###.###.#.###.###.###.#.#.#####.###.#.#.###.#.#.###.#.###.#####.#.###.#
#.#.........#.#.........#.......#...#.........#.................#.....#.#.......#.#.....#.#.....#.#.........#.....#.#.......#.#.............#.....#...#.....#.....#.......#.......#.#
###.#####.#.#.#.#.#.###.#.#.#.#.#.#.#.#.#.###.#.#.#.#.###.###.#.#.#.###.#.#.###.#.#.#.###.#.#.#####.###.###.#.###.#.###.###.#.###.#.###.#####.#.#.#.#####.#.#.#.#####.###.#.#.###.#.#
#...#...#.#...#.....#...#...#...#...#.#.......#.#.#.....#...#.#.....#.........#.#...#.......#.......#.#...#.....#...#.............#...............#.....#.#.....#...#.#...#.........#
#.###.#.#.#.#.#.#.#.#.#####.#####.#.#####.#######.#####.#.#########.###.#.###.#.#.###.#.#.#.#.#.#.#.#.#.#.###.#.###.#.#.#.#.###.#.#.#.###.#####.###.#.#.#.#.#.#.#.#.#.#.#.#.#####.###
#.#.....#...#.......#...#.#.#.#.#...#...#...#...#...................#...........#.....#.#...#.........#.#.......#.#...#.#.#.#...................#...#...#.#...#.....#.#1#.....#.....#
###.#.#####.#.#.#.#.###.#.###.#.#.#.#.#.###.#.#.#.#.#.#.#####.###.###.#.#.#.#.#.#.###.#.#.#.###.#######.#.###.#.#.#.#.###.#.#########.#.#.#.#.#.###.#.#.#####.###.#.#########.#.#.#.#
#.#...#.....#.....#...#.#.#...#.......#...#.....#.#...#.....#...#.....#...#.#.....#.......#...#...#.......#...#...#...#...#...........#.#.....#...#.........#.#.....#.#.#.......#...#
#.#.#.#.#####.#.#.###.#.#.#.#.#.###.#.###.#.#.###.#.#.###.#.###.#.###.#####.#.#.#.#.#.#.###.#.#.#.#.#.###.#####.#.#.###.#.#.###.#.#.#.#.#.#.#.#####.#.#.###.#.#.###.#.#.###.#.#.###.#
#.....#7#.#...#.#.................#...............#.#.#...#.#...#.#...#.....#...#.....#...#.#.#.......#...#...........#...........#.#.....#...#.........#.#.......#.#.#.....#.......#
#.#.#.###.#.#.###.#.#.#.#.#.#.###.#.#.#.###.#.###.#.#.#.#.#.#.#.###.#.#.#.#####.#.#.#.###.#.#.#####.#.#.###########.#.#####.#.#.#.###.#.#.#.#.#####.#.###.###.#.###.#.#.###.#.#######
#.#.....#.#.#.#...........#.#.#.......#...........#...#.......#...#.#...#.....#.#.....#...#.....#.#.......#.#.#.......#.#.......#.............#.#...#.#.#.#...........#.......#.....#
#.#####.#####.#.#.###.#.#.#.#.#####.#.#.#.###.###.#.#.#.#.#######.#.#.#.#.###.#.#.#.#.#.#.#######.#.###.###.#.#.#.#.#.#.#.#.#####.#.#.#######.#.#.###.#.#.#####.###.###.#.#.#.#.#.#.#
#.......#.#...#.....#...#.......#...#...#.....#...#.#...#...#.....#.#.#.#.....#.#.....#.....#...#...#...#.....#.#...#.#...#...#.............#.#...#.....#...#.....#.....#.#.....#.#.#
#.#.#####.#.###.#########.###.#.#.#.###.#.#.###.#.#.#.#.#.#.#.###.#.###.###.###.#####.#.###.#.#.#.#.#.#.#.###.#####.#.#.#.#.#.###.#.#.#.###.#.###.###.#.#.#.#.###.#.###.###.###.#.###
#...#.....#.#.#.#.........#...#.....#.........#...#.....#.....#.....#...................#.......#...#...#.....#.......#...#...#.......#.....#.#...#.#...#.#.........#.#.#...#.#.#...#
###.#.#.#.#.#.#.#.###.#.#.#######.###.#######.#####.#.#.#.###.#.#.###.#######.###.#.###.###########.#.#####.###.#####.#.#######.#########.###.###.#.#.#.#.#.#.#.#.#.#.###.#.#.#.#.#.#
#.....#...............#.............#...#.#.#.........#.#.....#...#.....#...#.....#.#.....#...#.#...#.#.....#.........#.#...............#.#.#...#.......#.#.....#.#...............#.#
#.#.###.#.###.###.#.#.#.#.###.#.#.#.#.#.#.#.#####.#.###.#.#.#.#.#.#.#.###.#.###.#.#.#.#.#.###.#.#.#.###.###.#.#####.#.#.#.#.#.#.#######.#.#.###.###.#.#.#.#.#.#.#.#.#####.#####.#.###
#...#...#...............#.......#...#.....#.....#.#...#.........#.#...#...#.....#...#.#...#...#...#...#.....#.#.....#.....#.#...#.....#.........#.........#.......#.......#3........#
#####.#.###.#.#.###.#####.#.#.#.###.#.#.#####.#.#.###.#.#.###.#.###.#.#.#.#.#.#.#.#.#.#.#.###.#.#####.#.#.#.#.#######.###.#.#####.#.#.#.#####.#.#.#######.#.###.###.#.#####.#.#.#.#.#
#.#...#...#...#.......#.....#...#.#...............#.#...#...#.#.....#.#.....#.#.#...#...#.........#.....#...#...........#.#.#.........#...........#...................#.....#.#.....#
#.#.###.#.#.#.#.#.###.#.#.#.#.#.#.#.#####.#.#######.#.###.###############.#.###.#.#.#.#.#####.###.#.#####.#.#.#.#.#.###.#.#.#.#.###.#.#.###.#.#####.#.#.#####.#########.#####.###.###
#.#.#.....#.....#...#...#...#.....#.........#.#...#...#.........#...#...#.......#.............#.............#.#.....#.#...#.#.......#...#.#.#...#.....#.#.......#...#...#.....#...#.#
#.#.#.#.#.#######.#.#.###.###.###.###.#.###.#.#.#.#.#.#.#.#.###.#.#.#########.#.#.###.###.#.#.#.#.#.#.#######.#.#####.#.#.#######.#.#.#.#.###.#.#.###.#.#####.#.#.#.#.#.#.#######.#.#
#.#.#.#...#...........#.#.....#.#...#.#.#.#.......#.#.....#...#.#...#.#.#...#...#.#.#.......#...#.#.....#.........#.....#.....#.#.....#...#.#.....#...#...#.......#.....#.....#.....#
#.#.#.###.#.#.###.###.#.#.#.#.#.#######.#.###.#####.###.#.#.#.###.#.#.#.###.#.###.#.###.#.###.#.#.#.###.#.#.#####.###.###.#.###.###.#.#.###.#####.#.#.###.###.###.#.###.###.#.#.#.#.#
#...#.................#.............#...#...#.......#.....#.#.#.........#...#...#.......#.#...#.....#...#.#.......#.#.......#.#...#.#.#.............#.....#...#.#...#.....#.#.#.....#
#.#.#####.#.#.#.###.#.###.#########.#.#.###.#.#.###.#.###.#.###.#####.#.#.#.#.#.#.#####.#.#.#.#####.#.#.#######.#.#.#.#####.#.#.#.#####.#.#.#.###.#####.#.#.###.#.#.#.###.#.###.#.#.#
#5....#...#.#...........#...#...#.#.#.#...#.#.#.....#...........#...#.#.......#.....#...#.........#.#.#.#.......#.#...#...#...#.#.#........2#...#.#...#...#.#...#.#...#.......#...#.#
#####################################################################################################################################################################################

        ";
    }
}
