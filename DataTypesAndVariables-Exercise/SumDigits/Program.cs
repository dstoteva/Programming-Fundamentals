using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int numInProcess = n;

            while (numInProcess > 0)
            {
                sum += numInProcess % 10;
                numInProcess /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
