using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakingFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> bestBread = new List<int>();
            int bestQuality = int.MinValue;
            double bestAverageQuality = double.MinValue;
            int bestLength = 11;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Bake It!")
                {
                    break;
                }
                int[] currentBread = input.Split('#').Select(int.Parse).ToArray();

                int currentQuality = 0;
                double currentAverageQuality = 0.0;
                int currentLength = 0;
                for (int i = 0; i < currentBread.Length; i++)
                {
                    currentQuality += currentBread[i];
                }
                currentLength = currentBread.Length;
                currentAverageQuality = (double)currentQuality / currentLength;

                if (currentQuality > bestQuality)
                {
                    bestBread = currentBread.ToList();
                    bestQuality = currentQuality;
                    bestAverageQuality = currentAverageQuality;
                    bestLength = currentLength;
                }
                else if (currentQuality == bestQuality)
                {
                    if (currentAverageQuality > bestAverageQuality)
                    {
                        bestBread = currentBread.ToList();
                        bestQuality = currentQuality;
                        bestAverageQuality = currentAverageQuality;
                        bestLength = currentLength;
                    }
                    else if (currentAverageQuality == bestAverageQuality)
                    {
                        if (currentLength < bestLength)
                        {
                            bestBread = currentBread.ToList();
                            bestQuality = currentQuality;
                            bestAverageQuality = currentAverageQuality;
                            bestLength = currentLength;
                        }
                    }
                }
            }
            Console.WriteLine($"Best Batch quality: {bestQuality}");
            Console.WriteLine(string.Join(" ", bestBread));
        }
    }
}
