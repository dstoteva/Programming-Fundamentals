using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] results = new int[num];
            for (int i = 0; i < num; i++)
            {
                int sum = 0;
                char [] name = Console.ReadLine().ToArray();
                int length = name.Length;
                int value = -1;
                foreach (char c in name)
                {
                    value = (int)c;
                    if ("AEOUIaeoui".Contains(c))
                    {
                        value *= length;
                    }
                    else
                    {
                        value /= length;
                    }
                    sum += value;
                }
                results[i] = sum;
            }
            Array.Sort(results);
            foreach(int n in results)
            {
                Console.WriteLine(n);
            }
        }
    }
}
