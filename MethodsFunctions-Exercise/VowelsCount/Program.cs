using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine().ToLower();
            PrintsVowelsCount(a);
        }
        public static void PrintsVowelsCount(string a)
        {
            char[] input = a.ToCharArray();
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'o' || input[i] == 'u' || input [i] == 'i' || input [i] == 'e')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
