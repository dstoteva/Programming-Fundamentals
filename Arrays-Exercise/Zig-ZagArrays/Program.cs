using System;
using System.Linq;

namespace Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstLine = new int[n];
            int[] secondLine = new int[n];


            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 != 0)
                {
                    firstLine[i] = arr[1];
                    secondLine[i] = arr[0];
                }
                else
                {
                    firstLine[i] = arr[0];
                    secondLine[i] = arr[1];
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(firstLine[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(secondLine[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
