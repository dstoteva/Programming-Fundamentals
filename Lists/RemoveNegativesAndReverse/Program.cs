using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> line = Console.ReadLine().Split().Select(int.Parse).ToList();

            line.RemoveAll(n => n < 0);

            if (line.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                for (int i = line.Count - 1; i >= 0; i--)
                {
                    Console.Write(line[i] + " ");
                }
            }
        }
    }
}
