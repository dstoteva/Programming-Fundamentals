﻿using System;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split();
            string[] secondLine = Console.ReadLine().Split();

            for (int i = 0; i < secondLine.Length; i++)
            {
                for (int j = 0; j < firstLine.Length; j++)
                {
                    if (secondLine[i] == firstLine[j])
                    {
                        Console.Write(firstLine[j] + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
