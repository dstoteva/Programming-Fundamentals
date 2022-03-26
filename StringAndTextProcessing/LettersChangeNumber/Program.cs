using System;
using System.Collections.Generic;
using System.Linq;

namespace LettersChangeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var allNumbers = new List<double>();

            for (int i = 0; i < input.Length; i++)
            {
                string combination = input[i];
                char firstChar = combination[0];
                char lastChar = combination[combination.Length - 1];
                int number = int.Parse(combination.Substring(1, combination.Length - 2));

                double currentResult = 0.0;
                if (char.IsUpper(firstChar))
                {
                    int position = Char.ToLower(firstChar) - 96;
                    currentResult = (double)number / position;
                }
                else
                {
                    int position = firstChar - 96;
                    currentResult = number * position;  
                }

                if (char.IsUpper(lastChar))
                {
                    int position = Char.ToLower(lastChar) - 96;
                    currentResult -= position;
                }
                else
                {
                    int position = lastChar - 96;
                    currentResult += position;
                }
                allNumbers.Add(currentResult);
            }
            double result = 0.0;
            foreach (var number in allNumbers)
            {
                result += number;
                if (allNumbers.IndexOf(number) == allNumbers.Count - 1)
                {
                    Console.WriteLine($"{result:f2}");
                }
            }
        }
    }
}
