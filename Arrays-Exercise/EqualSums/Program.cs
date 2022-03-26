using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < n.Length; i++)
            {
                int leftSum = 0;
                int rigtSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += n[j];
                }
                for (int k = i + 1; k < n.Length; k++)
                {
                    rigtSum += n[k];
                }
                if (leftSum == rigtSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
