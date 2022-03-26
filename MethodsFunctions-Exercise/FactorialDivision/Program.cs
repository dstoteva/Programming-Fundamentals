using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());


            double output = (double)CalculatesFactorial(a) / (double)CalculatesFactorial(b);
            Console.WriteLine($"{output:f2}");
        }
        static long CalculatesFactorial(int num)
        {
            long result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
