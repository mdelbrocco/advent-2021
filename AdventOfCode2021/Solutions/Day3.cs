using System;
using System.IO;

namespace AdventOfCode2021.Solutions
{
  public class Day3
  {
    public static void Solve()
    {
      var readings = File.ReadAllLines("../../../Inputs/Day3.txt");

      Part1(readings);
    }

    // https://adventofcode.com/2021/day/3
    private static void Part1(string[] readings)
    {
      var numberOfReadings = readings.Length;

      var bit0Sum = 0;
      var bit1Sum = 0;
      var bit2Sum = 0;
      var bit3Sum = 0;
      var bit4Sum = 0;
      var bit5Sum = 0;
      var bit6Sum = 0;
      var bit7Sum = 0;
      var bit8Sum = 0;
      var bit9Sum = 0;
      var bit10Sum = 0;
      var bit11Sum = 0;

      foreach (var reading in readings)
      {
        if (reading[0] == '1') { bit0Sum++; }
        if (reading[1] == '1') { bit1Sum++; }
        if (reading[2] == '1') { bit2Sum++; }
        if (reading[3] == '1') { bit3Sum++; }
        if (reading[4] == '1') { bit4Sum++; }
        if (reading[5] == '1') { bit5Sum++; }
        if (reading[6] == '1') { bit6Sum++; }
        if (reading[7] == '1') { bit7Sum++; }
        if (reading[8] == '1') { bit8Sum++; }
        if (reading[9] == '1') { bit9Sum++; }
        if (reading[10] == '1') { bit10Sum++; }
        if (reading[11] == '1') { bit11Sum++; }
      }

      var stringVersionOfEpsilonReading =
        $"{(bit0Sum > numberOfReadings / 2 ? "1" : "0")}" +
        $"{(bit1Sum > numberOfReadings / 2 ? "1" : "0")}" +
        $"{(bit2Sum > numberOfReadings / 2 ? "1" : "0")}" +
        $"{(bit3Sum > numberOfReadings / 2 ? "1" : "0")}" +
        $"{(bit4Sum > numberOfReadings / 2 ? "1" : "0")}" +
        $"{(bit5Sum > numberOfReadings / 2 ? "1" : "0")}" +
        $"{(bit6Sum > numberOfReadings / 2 ? "1" : "0")}" +
        $"{(bit7Sum > numberOfReadings / 2 ? "1" : "0")}" +
        $"{(bit8Sum > numberOfReadings / 2 ? "1" : "0")}" +
        $"{(bit9Sum > numberOfReadings / 2 ? "1" : "0")}" +
        $"{(bit10Sum > numberOfReadings / 2 ? "1" : "0")}" +
        $"{(bit11Sum > numberOfReadings / 2 ? "1" : "0")}";

      int epsilonReading = Convert.ToInt32(stringVersionOfEpsilonReading, 2);

      var stringVersionOfGammaReading =
      $"{(bit0Sum < numberOfReadings / 2 ? "1" : "0")}" +
      $"{(bit1Sum < numberOfReadings / 2 ? "1" : "0")}" +
      $"{(bit2Sum < numberOfReadings / 2 ? "1" : "0")}" +
      $"{(bit3Sum < numberOfReadings / 2 ? "1" : "0")}" +
      $"{(bit4Sum < numberOfReadings / 2 ? "1" : "0")}" +
      $"{(bit5Sum < numberOfReadings / 2 ? "1" : "0")}" +
      $"{(bit6Sum < numberOfReadings / 2 ? "1" : "0")}" +
      $"{(bit7Sum < numberOfReadings / 2 ? "1" : "0")}" +
      $"{(bit8Sum < numberOfReadings / 2 ? "1" : "0")}" +
      $"{(bit9Sum < numberOfReadings / 2 ? "1" : "0")}" +
      $"{(bit10Sum < numberOfReadings / 2 ? "1" : "0")}" +
      $"{(bit11Sum < numberOfReadings / 2 ? "1" : "0")}";

      int gammaReading = Convert.ToInt32(stringVersionOfGammaReading, 2);

      Console.WriteLine($"Epsilon reading: {epsilonReading}");
      Console.WriteLine($"Gamma reading: {gammaReading}");
      Console.WriteLine($"Multiplied together: {epsilonReading * gammaReading}");
    }
  }
}
