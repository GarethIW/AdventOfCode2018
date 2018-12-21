using System;
using System.IO;

namespace Day1
{
    static class Part1
    {
        public static void Go()
        {
            // We can handily read all the lines of the file to a sting array with ReadAllLines
            var lines = File.ReadAllLines("input.txt");

            var result = 0;
            foreach(var line in lines)
            {
                // TryParse correctly parses + numbers, so we don't need to do any further work
                if (!int.TryParse(line, out var l))
                {
                    Console.WriteLine($"Couldn't parse {line}");
                    continue;
                }

                result += l;
                Console.WriteLine($"{line}\t\t{result}");
            }

            Console.ReadLine();
        }
    }
}
