using System;
using System.Collections.Generic;
using System.IO;

namespace Day1
{
    static class Part2
    {
        public static void Go()
        {
            // We can handily read all the lines of the file to a sting array with ReadAllLines
            var lines = File.ReadAllLines("input.txt");

            // Hashset for speed
            HashSet<int> frequencyHistory = new HashSet<int>();
            var result = 0;

            // We need to keep looping until we get a repeated frequency!
            var found = false;
            while (!found)
            {
                foreach (var line in lines)
                {
                    // TryParse correctly parses + numbers, so we don't need to do any further work
                    if (!int.TryParse(line, out var l))
                    {
                        Console.WriteLine($"Couldn't parse {line}");
                        continue;
                    }

                    result += l;
                    Console.WriteLine($"{line}\t\t{result}");

                    // Try to add to the hashset and carry on
                    if (frequencyHistory.Add(result))
                        continue;

                    // If we can't add to the hashset, it's a repeat result!
                    Console.WriteLine($"--- FREQUENCY FOUND: {result} ---");
                    found = true;
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
