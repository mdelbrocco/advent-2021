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

      var numberOfIncreases = 0;

      for (int i = 0; i < depthReadings.Length - 1; i++)
      {
        var first = int.Parse(depthReadings[i]);
        var second = int.Parse(depthReadings[i + 1]);

        if (second > first)
          numberOfIncreases++;
      }

      Console.WriteLine(numberOfIncreases); // 1559
    }
  }
}
