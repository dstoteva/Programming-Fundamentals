using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());

            while (true)
            {
                List<string> currentCommand = Console.ReadLine().Split().ToList();
                

                if (currentCommand[0] == "end")
                {
                    break;
                }
                if (currentCommand[0] == "Add")
                {
                    int newWagon = int.Parse(currentCommand[1]);
                    wagons.Add(newWagon);
                }
                else
                {
                    int newPeople = int.Parse(currentCommand[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + newPeople <= capacity)
                        {
                            wagons[i] += newPeople;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
