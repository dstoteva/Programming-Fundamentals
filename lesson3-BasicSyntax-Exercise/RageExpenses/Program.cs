using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double headsetTotal = (lostGamesCount / 2) * headsetPrice;
            double mouseTotal = (lostGamesCount / 3) * mousePrice;
            double keyboardTotal = (lostGamesCount / 6) * keyboardPrice; ;
            double displayTotal = (lostGamesCount / 12) * displayPrice;

            double expenses = headsetTotal + mouseTotal + keyboardTotal + displayTotal;
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
            
            
        }
    }
}
