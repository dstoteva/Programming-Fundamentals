using System;
using System.Linq;
using System.Collections.Generic;

namespace AMinorTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, long>();
            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
                long quantity = long.Parse(Console.ReadLine());

                if (result.ContainsKey(resource))
                {
                    result[resource] += quantity;
                }
                else
                {
                    result[resource] = quantity;
                }
            }
            foreach (var kvp in result)
            {
                Console.WriteLine(kvp.Key + " -> " + kvp.Value);
            }
        }
    }
}
