using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int j = 0; j < n*2; j++)
            {
                if (j % 2 != 0)
                {
                    Console.WriteLine(j);
                    sum += j;   
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
