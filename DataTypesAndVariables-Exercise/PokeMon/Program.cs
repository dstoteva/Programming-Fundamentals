using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int count = 0;
            int nStartValue = n;
            while (n-m >= 0)
            {
                n -= m;
                count++;

                if (n == nStartValue/2 && y!=0)
                {
                    n = n / y;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
