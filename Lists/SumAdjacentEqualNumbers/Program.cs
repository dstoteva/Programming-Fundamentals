using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> line = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < line.Count - 1; i++)
            {
                if (line[i] == line[i + 1])
                {
                    line[i] += line[i + 1];
                    line.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", line));
        }
    }
}
