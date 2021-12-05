using System;

namespace AdventOfCode2021
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello Advent!");

      Day1();
    }

    private static void Day1()
    {
      var depthReadings = System.IO.File.ReadAllLines("../../../Inputs/Day1.txt");

      Part1(depthReadings);
      Part2(depthReadings);
    }

    // Count how many times the number increases from one to another\
    // https://adventofcode.com/2021/day/1
    private static void Part1(string[] depthReadings)
    {
      var numberOfIncreases = 0;

      for (int i = 0; i < depthReadings.Length - 1; i++)
      {
        var firstReading = int.Parse(depthReadings[i]);
        var secondReading = int.Parse(depthReadings[i + 1]);

        if (secondReading > firstReading)
          numberOfIncreases++;
      }

      Console.WriteLine($"Part 1 Solution: {numberOfIncreases}");
    }

    // Count how many times a window of 3 numbers increases moving forward
    // https://adventofcode.com/2021/day/1#part2
    private static void Part2(string[] depthReadings)
    {
      var numberOfIncreases = 0;

      for (int i = 0; i < depthReadings.Length - 3; i++)
      {
        var firstWindowSum = int.Parse(depthReadings[i]) + int.Parse(depthReadings[i + 1]) + int.Parse(depthReadings[i + 2]);
        var secondWindowSum = int.Parse(depthReadings[i+1]) + int.Parse(depthReadings[i + 2]) + int.Parse(depthReadings[i + 3]);

        if (secondWindowSum > firstWindowSum)
          numberOfIncreases++;
      }

      Console.WriteLine($"Part 2 Solution: {numberOfIncreases}");
    }
  }
}
