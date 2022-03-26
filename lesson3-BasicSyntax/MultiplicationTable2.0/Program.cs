using System;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multip = int.Parse(Console.ReadLine());
            int product = 0;

            if (multip > 10)
            {
                product = n * multip;
                Console.WriteLine($"{n} X {multip} = {product}");
            }
            else
            {
                for (int i = multip; i <= 10; i++)
                {
                    product = n * i;
                    Console.WriteLine($"{n} X {i} = {product}");
                }
            }
        }
    }
}
