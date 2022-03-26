using System;

namespace IntegerOperationss
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());

            long result = n + m;
            result /= p;
            result *= q;

            Console.WriteLine(result);
        }
    }
}
