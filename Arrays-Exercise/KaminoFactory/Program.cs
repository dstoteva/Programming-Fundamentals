using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int index = 0;
            int sequenceSum = 1;
            int[] DNA = new int[length];
            int firstNumberOne = 10;
            int sumOfOnes = 0;
            int currentIndex = 0;

            while (true)
            {
                int currentSequenceSum = 1;
                int currentSumOfOnes = 0;

                string input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }

                int[] currentDNA = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currentFirstNumberOne = -1;
                currentIndex++;
                for (int i = 0; i < length - 1; i++)
                {
                    if (currentDNA[i] == 1 && currentDNA[i + 1] == 1)
                    {
                        if (currentSequenceSum == 1)
                        {
                            currentFirstNumberOne = i;
                        }
                        currentSequenceSum++;
                    }
                }
                for (int i = 0; i < length; i++)
                {
                    currentSumOfOnes += currentDNA[i];
                }

                if (currentSequenceSum > sequenceSum)
                {
                    sumOfOnes = currentSumOfOnes;
                    index = currentIndex;
                    sequenceSum = currentSequenceSum;
                    DNA = (int[])currentDNA.Clone();
                    firstNumberOne = currentFirstNumberOne;
                }
                else if (currentSequenceSum == sequenceSum)
                {
                    if (currentFirstNumberOne < firstNumberOne)
                    {
                        sumOfOnes = currentSumOfOnes;
                        index = currentIndex;
                        sequenceSum = currentSequenceSum;
                        DNA = (int[])currentDNA.Clone();
                        firstNumberOne = currentFirstNumberOne;
                    }
                    else if (currentFirstNumberOne == firstNumberOne)
                    {
                        if (currentSumOfOnes > sumOfOnes)
                        {
                            sumOfOnes = currentSumOfOnes;
                            index = currentIndex;
                            sequenceSum = currentSequenceSum;
                            DNA = (int[])currentDNA.Clone();
                            firstNumberOne = currentFirstNumberOne;
                        }
                    }
                }
            }
            Console.WriteLine($"Best DNA sample {index} with sum: {sumOfOnes}.");
            Console.WriteLine(String.Join(" ", DNA));
        }
    }
}
