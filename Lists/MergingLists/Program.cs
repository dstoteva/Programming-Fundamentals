using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> merged = new List<int>();
            int minLength = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < minLength; i++)
            {
                merged.Add(firstList[i]);
                merged.Add(secondList[i]);

            }
            if (firstList.Count > secondList.Count)

                merged.AddRange(GetRemainingElements(firstList, secondList));

            else if (secondList.Count > firstList.Count)

                merged.AddRange(GetRemainingElements(secondList, firstList));

            Console.WriteLine(string.Join(" ", merged));
        }
        public static List <int> GetRemainingElements(List <int> firstList, List <int> secondList)
        {
            List<int> remain = new List<int>();
            for (int i = secondList.Count; i < firstList.Count; i++)
            {
                remain.Add(firstList[i]);
            }
            return remain;
        }
    }
}
