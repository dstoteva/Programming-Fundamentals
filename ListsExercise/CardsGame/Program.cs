using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstCards = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> secondCards = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstCards.Count != 0 && secondCards.Count != 0)
            {
                int firstCard = firstCards[0];
                int secondCard = secondCards[0];
                if (firstCard > secondCard)
                {
                    firstCards.RemoveAt(0);
                    secondCards.RemoveAt(0);

                    firstCards.Add(firstCard);
                    firstCards.Add(secondCard);
                }
                else if (secondCard > firstCard)
                {
                    firstCards.RemoveAt(0);
                    secondCards.RemoveAt(0);

                    secondCards.Add(secondCard);
                    secondCards.Add(firstCard);
                }
                else
                {
                    firstCards.RemoveAt(0);
                    secondCards.RemoveAt(0);
                }
            }
            if (firstCards.Count > 0)
            {
                int sum = firstCards.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else if (secondCards.Count > 0)
            {
                int sum = secondCards.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}
