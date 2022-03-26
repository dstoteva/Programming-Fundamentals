using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double startBalance = currentBalance;
            double gamePrice = 0;

            while (true)
            {
                string gameName = Console.ReadLine();

                if (gameName == "Game Time")
                {
                    break;
                }
                else
                {
                    switch (gameName)
                    {
                        case "OutFall 4":
                            gamePrice = 39.99;
                            break;
                        case "CS: OG":
                            gamePrice = 15.99;
                            break;
                        case "Zplinter Zell":
                            gamePrice = 19.99;
                            break;
                        case "Honored 2":
                            gamePrice = 59.99;
                            break;
                        case "RoverWatch":
                            gamePrice = 29.99;
                            break;
                        case "RoverWatch Origins Edition":
                            gamePrice = 39.99;
                            break;
                        default:
                            gamePrice = 0;
                            break;
                    }
                }
                if (gamePrice > 0 && currentBalance - gamePrice > 0)
                {
                    Console.WriteLine($"Bought {gameName}");
                    currentBalance -= gamePrice;
                }
                else if (gamePrice == 0 && currentBalance - gamePrice > 0)
                {
                    Console.WriteLine("Not Found");
                }
                else if (currentBalance - gamePrice < 0)
                {
                    Console.WriteLine("Too Expensive");
                }
                else if (currentBalance - gamePrice == 0)
                {
                    Console.WriteLine("Out of money!");
                    currentBalance -= gamePrice;
                    break;
                }
            }
            if (currentBalance > 0)
            {
                Console.WriteLine($"Total spent: ${(startBalance - currentBalance):f2}. Remaining: {currentBalance:f2}");
            }
        }
    }
}
