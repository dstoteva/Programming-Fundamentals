using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            int index = 0;
            bool areEqual = true;

            for (int i = 0; i < firstLine.Length; i++)
            {
                if (firstLine[i] == secondLine [i])
                {
                    sum += firstLine[i];
                }
                else
                {
                    index = i;
                    areEqual = false;
                    break;
                }
            }
            if (areEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
            }
        }
    }
}
