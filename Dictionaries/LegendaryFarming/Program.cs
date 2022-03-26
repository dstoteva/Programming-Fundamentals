using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, long>()
            {
                ["fragments"] = 0,
                ["shards"] = 0,
                ["motes"] = 0
            };
            string reward = " ";
            while (true)
            {
                string[] input = Console.ReadLine().Split();

                for (int i = 0; i < input.Length; i++)
                {
                    if (dictionary["fragments"] >= 250)
                    {
                        dictionary["fragments"] -= 250;
                        reward = "Valanyr";
                        break;
                    }
                    else if (dictionary["motes"] >= 250)
                    {
                        dictionary["motes"] -= 250;
                        reward = "Dragonwrath";
                        break;
                    }
                    else if (dictionary["shards"] >= 250)
                    {
                        dictionary["shards"] -= 250;
                        reward = "Shadowmourne";
                        break;
                    }
                    else if (i % 2 != 0)
                    {
                        string word = input[i].ToLower();
                        long value = long.Parse(input[i - 1]);
                        if (dictionary.ContainsKey(word.ToLower()))
                        {
                            dictionary[word] += value;
                        }
                        else
                        {
                            dictionary.Add(word, value);
                        }
                    }
                }
                if (reward != " ")
                {
                    break;
                }
            }
            Console.WriteLine($"{reward} obtained!");
            var firstThree = dictionary.Take(3).OrderBy(x => x.Value).ThenBy(x => x.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            foreach (var kvp in firstThree)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            var last = dictionary.Skip(3).OrderBy(kvp => kvp.Value).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            foreach (var kvp in last)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
