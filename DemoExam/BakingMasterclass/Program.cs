using System;

namespace BakingMasterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());

            double eggTotal = eggPrice * 10 * students;
            double flourTotal = flourPrice * (students - students / 5);
            double apronTotal = apronPrice * (students + (int)Math.Ceiling(students*0.2));

            double totalPrice = eggTotal + flourTotal + apronTotal;

            if (totalPrice <= budget)
            {
                Console.WriteLine($"Items purchased for {totalPrice:f2}$.");
            }
            else
            {
                Console.WriteLine($"{(totalPrice - budget):f2}$ more needed.");
            }
        }
    }
}
