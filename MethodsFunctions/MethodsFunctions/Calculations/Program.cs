using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "add":
                    Addition(a, b);
                    break;
                case "multiply":
                    Multiplication(a, b);
                    break;
                case "substract":
                    Substraction(a, b);
                    break;
                case "divide":
                    Division(a, b);
                    break;
                default:
                    break;
            }
        }
        public static void Addition(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Multiplication (int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void Substraction (int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void Division (int a, int b)
        {
            Console.WriteLine(a/b);
        }
    }
}
