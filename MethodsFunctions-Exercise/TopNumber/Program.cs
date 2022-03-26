using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintsMaster(n);
        }
        static void PrintsMaster(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (SumIs8(i) && HoldsOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool SumIs8 (int n)
        {
            bool SumIs8 = false;
            int sum = 0;
            for (int i = n; i > 0;)
            {
                int currentNum = i % 10;
                i /= 10;
                sum += currentNum;
                if (sum % 8 == 0 && i == 0)
                {
                    SumIs8 = true;
                    break;
                }
            }
            return SumIs8;
        }
        static bool HoldsOddDigit(int n)
        {
            bool holds = false;
            for (int i = n; i > 0;)
            {
                if ((i % 10) % 2 != 0)
                {
                    holds = true;
                    break;
                }
                i /= 10;
            }
            return holds;
        }
    }
}
