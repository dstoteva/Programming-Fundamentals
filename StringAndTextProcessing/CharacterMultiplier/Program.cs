using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string first = input[0];
            string second = input[1];

            Console.WriteLine(ReturnsSum(first, second));
        }
        public static long ReturnsSum(string first, string second)
        {
            long sum = 0;
            int smallerLength = Math.Min(first.Length, second.Length);
            int biggerLength = Math.Max(first.Length, second.Length);
            for (int i = 0; i < smallerLength; i++)
            {
                sum += first[i] * second[i];
            }
            if (biggerLength - smallerLength > 0)
            {
                for (int i = smallerLength; i < biggerLength; i++)
                {
                    if (first.Length > second.Length)
                    {
                        sum += first[i];
                    }
                    else
                    {
                        sum += second[i];
                    }
                }
            }
            return sum;
        }
    }
}
