using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> line = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> numAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();
            int number = numAndPower[0];
            int power = numAndPower[1];

            for (int i = 0; i < line.Count; i++)
            {
                int leftPower = power;
                int rightPower = power;
                if (number == line[i])
                {
                    if (i < power)
                    {
                        leftPower = i;
                    }
                    else if (line.Count - 1 < i + power)
                    {
                        rightPower = line.Count - 1 - i;
                    }
                    for (int j = leftPower; j <= rightPower; j++)
                    {
                        line.RemoveAt(j);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", line));
        }
    }
}
