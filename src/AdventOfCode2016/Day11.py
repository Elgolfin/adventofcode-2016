#!/usr/bin/python

"""
Borrowed from https://github.com/leveneg/2016AdventOfCode
I know...
"""

def calc(numItems):
  return sum(2 * sum(numItems[:x]) - 3 for x in range(1,4))

def main():
  ans1 = calc([8,2,0,0])
  ans2 = calc([12,2,0,0])

  print 'Part 1 - No. Moves: {}'.format(ans1)
  print 'Part 2 - No. Moves: {}'.format(ans2)

if __name__ == '__main__':
  main()