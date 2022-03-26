using System;

namespace MultiplyEvenesByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));

            int result = GetMultipleOfAll(num);
            Console.WriteLine(result);
        }
        static int GetSumOfEven(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastNum = n % 10;
                if (lastNum % 2 == 0)
                {
                    sum += lastNum;
                }
                n /= 10;
            }
            return sum;
        }
        static int GetSumOfOdd(int n)
        {
            int sum = 0;
           
            while (n > 0)
            {
                int lastNum = n % 10;
                if (lastNum % 2 != 0)
                {
                    sum += lastNum;
                }
                n /= 10;
            }
            return sum;
        }
        static int GetMultipleOfAll(int n)
        {
            return GetSumOfEven(n) * GetSumOfOdd(n);
        }
    }
}
