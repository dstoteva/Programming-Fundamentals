using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int equalSequence = 1;
            int longestEqualSequence = 0;
            int number = 0;

            for (int i = 0; i < elements.Length - 1; i++)
            {
                if (elements[i] == elements[i+1])
                {
                    equalSequence ++;
                }
                else
                {
                    equalSequence = 1;
                }
                if (equalSequence > longestEqualSequence)
                {
                    longestEqualSequence = equalSequence;
                    number = elements[i];
                }
            }
            for (int i = 0; i < longestEqualSequence; i++)
            {
                Console.Write(number + " ");
            }
        }
    }
}
