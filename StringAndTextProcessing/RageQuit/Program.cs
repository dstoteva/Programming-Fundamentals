using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper().ToString();
            var uniqueSymbols = new List<char>();
            var sequenceAndCount = new Dictionary<string, double>();
            double count = 0;
            string sequence = "";
            int indexOfLastNumber = -1;

            int index = input.IndexOf(char.IsDigit(input))
        }
    }
}


