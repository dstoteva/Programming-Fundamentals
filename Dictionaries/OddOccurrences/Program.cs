using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split();

            var oddOccurences = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!oddOccurences.ContainsKey(words[i]))
                {
                    oddOccurences.Add(words[i], 1);
                }
                else
                {
                    oddOccurences[words[i]]++;
                }
            }
            foreach (var kvp in oddOccurences)
            {
                int count = kvp.Value;
                if (count % 2 != 0)
                {
                    Console.Write(kvp.Key + " ");
                }
            }
        }
    }
}
