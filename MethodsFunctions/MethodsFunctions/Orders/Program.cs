using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            PrintTotalPrice(product, n);
        }
        public static void PrintTotalPrice(string product, int quantity)
        {
            double totalPrice = 0;
            switch (product)
            {
                case "coffee":
                    totalPrice = 1.5 * quantity;
                    break;
                case "water":
                    totalPrice = quantity;
                    break;
                case "coke":
                    totalPrice = 1.4 * quantity;
                    break;
                case "snacks":
                    totalPrice = 2 * quantity;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
