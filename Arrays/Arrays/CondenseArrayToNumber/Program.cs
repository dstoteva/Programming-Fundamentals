using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            while (true)
            {
                

                if (input.Length == 1)
                {
                    sum = input[0];
                    break;
                }
                else
                {
                    int[] condensed = new int[input.Length - 1];

                    for (int i = 0; i < condensed.Length; i++)
                {
                        condensed[i] = input[i] + input[i + 1];
                    
                }
                input = condensed;

                }
            }
            Console.WriteLine(sum);
        }
    }
}
