using System;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char first = input[0];
            string result = "" + first;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i -1] !=input[i])
                {
                    result += input[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
