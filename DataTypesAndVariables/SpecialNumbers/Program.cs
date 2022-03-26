using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sumOfDigits = 0;
                int digits = i;

                while (digits>0)
                {
                    sumOfDigits += digits % 10;
                    digits /= 10;
                }

                bool numIsSpecial = (sumOfDigits == 5 || sumOfDigits == 11 || sumOfDigits == 7);

                Console.WriteLine($"{i} -> {numIsSpecial}");
            }
        }
    }
}
