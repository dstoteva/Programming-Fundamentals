using System;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] element = Console.ReadLine().Split();

            for (int i = 0; i < element.Length - 1 / 2 ; i++)
            {
                string temp = element[i];
                element[i] = element[element.Length - 1 - i];
                element[element.Length - 1 - i] = temp;
            }
            Console.WriteLine();
        }
    }
}
