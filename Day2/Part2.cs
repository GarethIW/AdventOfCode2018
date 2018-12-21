using System;
using System.IO;

namespace Day2
{
    static class Part2
    {
        public static void Go()
        {
            var lines = File.ReadAllLines("input.txt");

            var found = false;
            foreach (var line in lines)
            {
                foreach (var line2 in lines)
                {
                    if (line == line2) continue;

                    var diff = 0;
                    var diffPos = 0;
                    for (var i = 0; i < line.Length; i++)
                        if (line[i] != line2[i])
                        {
                            diff++;
                            diffPos = i;
                        }

                    
                    if(diff==1)
                    {
                        Console.WriteLine($"Boxes:\t\t{line}\t\t{line2}");
                        Console.WriteLine($"Result ID:\t\t{line.Remove(diffPos, 1)}");
                        found = true;
                        break;
                    }
                }
                if (found) break;
            }

            Console.ReadLine();
        }
    }
}
