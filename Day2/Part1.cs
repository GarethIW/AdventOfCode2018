using System;
using System.IO;

namespace Day2
{
    static class Part1
    {
        public static void Go()
        {
            var lines = File.ReadAllLines("input.txt");

            var twoSame = 0;
            var threeSame = 0;
            foreach (var line in lines)
            {
                var foundTwo = false;
                var foundThree = false;
                for (var i=0;i<line.Length;i++)
                {
                    var c = line[i];
                    var count = 0;
                    for (var j=0;j<line.Length;j++)
                    {
                        if (line[j] == c) count++;
                    }
                    if (count == 2) foundTwo=true;
                    if (count == 3) foundThree=true;
                }
                if (foundTwo) twoSame++;
                if (foundThree) threeSame++;

                Console.WriteLine($"{line}\t\t{twoSame}\t\t{threeSame}");
            }

            var result = twoSame * threeSame;
            Console.WriteLine($"Checksum: {result}");

            Console.ReadLine();
        }
    }
}
