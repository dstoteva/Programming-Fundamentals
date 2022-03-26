using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> line = Console.ReadLine().Split().Select(double.Parse).ToList();

            int initialLength = line.Count;
            for (int i = 0; i < initialLength/ 2; i++)
            {
                line[i] += line[line.Count - 1];
                line.RemoveAt(line.Count - 1);            
            }
            Console.WriteLine(string.Join(" ", line));
        }
    }
}
