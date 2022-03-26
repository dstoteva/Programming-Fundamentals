using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double result = Calculates(a, operation, b);
            Console.WriteLine(result);

        }
        public static double Calculates (int a, char operation, int b)
        {
            double result = 0;
            switch (operation)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
