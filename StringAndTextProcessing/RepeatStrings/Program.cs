using System;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] a = Console.ReadLine().Split();
            string result = "";
            foreach (string word in a)
            {
                int times = word.Length;

                for (int i = 0; i <times; i++)
                {
                    result += word;
                }
            }
            Console.WriteLine(result);
        }
    }
}
