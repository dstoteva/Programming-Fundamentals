using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            PrintsASCII(a, b);
        }
        public static void PrintsASCII(char a, char b)
        {
            if (a < b)
            {
                for (int i = a + 1; i < b; i++)
                {
                    char result = Convert.ToChar(i);
                    Console.Write(result + " ");
                }
            }
            else if (b < a)
            {
                for (int i = b + 1; i < a; i++)
                {
                    char result = Convert.ToChar(i);
                    Console.Write(result + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
