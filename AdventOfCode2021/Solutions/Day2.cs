using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2021.Solutions
{
  public class Day2
  {
    public static void Solve()
    {
      var lines = File.ReadAllLines("../../../Inputs/Day2.txt");

      var movements = lines.Select(line =>
      {
        var tokens = line.Split(" ");
        var dir = tokens.First();
        var mag = int.Parse(tokens.Last());
        return new Vector(dir, mag);
      }).ToList();
      Part1(movements);
    }

    // Figure out the submarine's ending position.
    // https://adventofcode.com/2021/day/2
    private static void Part1(List<Vector> movements)
    {
      var horizontalPosition = 0;
      var depth = 0;

      foreach (var movement in movements)
      {
        if (movement.Direction == "forward")
        {
          horizontalPosition += movement.Magnitude;
        }
        else if (movement.Direction == "down")
        {
          depth += movement.Magnitude;
        }
        else if (movement.Direction == "up")
        {
          depth -= movement.Magnitude;
        }
        else
        {
          Console.WriteLine("UNEXPECTED INPUT!");
        }
      }

      Console.WriteLine($"Horizontal Position: {horizontalPosition}");
      Console.WriteLine($"Depth: {depth}");
      Console.WriteLine($"Multiplied Together: {horizontalPosition * depth}");
    }

    private static void Part2()
    {
      // TODO: after solving part 1
    }

    private class Vector
    {
      public string Direction { get; set; }
      public int Magnitude { get; set; }

      public Vector(string direction, int magnitude)
      {
        Direction = direction;
        Magnitude = magnitude;
      }
    }
  }
}
