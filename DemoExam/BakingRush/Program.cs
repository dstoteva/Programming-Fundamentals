using System;
using System.Linq;

namespace BakingRush
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = 100;
            int coins = 100;
            string[] events = Console.ReadLine().Split("|").ToArray();
            bool dayIsCompleted = true;

            for (int i = 0; i < events.Length; i++)
            {
                string[] currentEvent = events[i].Split("-").ToArray();
                string command = currentEvent[0];
                int value = int.Parse(currentEvent[1]);
                
                if (command == "rest")
                {
                    if (energy + value <= 100)
                    {
                        energy += value;
                    }
                    else if (energy + value > 100)
                    {
                        value = 100 - energy;
                        energy += value;
                    }
                    Console.WriteLine($"You gained {value} energy.");
                    Console.WriteLine($"Current energy: {energy}.");
                }
                else if (command == "order")
                {                 
                    if (energy - 30 >= 0)
                    {
                        Console.WriteLine($"You earned {value} coins.");
                        energy -= 30;
                        coins += value;
                    }
                    else if (energy - 30 < 0)
                    {
                        energy += 50;
                        Console.WriteLine("You had to rest!");
                    }
                }
                else
                {                  
                    if (coins - value > 0)
                    {
                        Console.WriteLine($"You bought {command}.");
                        coins -= value;
                    }
                    else if (coins - value <= 0)
                    {
                        Console.WriteLine($"Closed! Cannot afford {command}.");
                        dayIsCompleted = false;
                        break;
                    }
                }
            }
            if (dayIsCompleted)
            {
                Console.WriteLine("Day completed!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Energy: {energy}");
            }
        }
    }
}
