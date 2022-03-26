using System;

namespace ExchangeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int tempN = n;
            n = m;
            m = tempN;

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {m}");
            Console.WriteLine($"b = {n}");
            Console.WriteLine("After:");
            Console.WriteLine($"a = {n}");
            Console.WriteLine($"b = {m}");
        }
    }
}
