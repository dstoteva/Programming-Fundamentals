using System;

namespace AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(Substract(a, b, c));
        }
        static int Sum (int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        static int Substract(int a, int b, int c)
        {
            int result = Sum(a, b) - c;
            return result;
        }
    }
}
