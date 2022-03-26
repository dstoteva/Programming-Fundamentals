using System;
using System.Linq;
using System.Collections.Generic;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            char [] line = Console.ReadLine().Where(x => x != ' ').ToArray();

            var result = new Dictionary<char, int>();

            foreach (var letter in line)
            {
                if (result.ContainsKey(letter))
                {
                    result[letter]++;
                }
                else
                {
                    result[letter] = 1;
                }
            }
            foreach (var kvp in result)
            {
                Console.WriteLine(kvp.Key +" -> " + kvp.Value);
            }
        }
    }
}
