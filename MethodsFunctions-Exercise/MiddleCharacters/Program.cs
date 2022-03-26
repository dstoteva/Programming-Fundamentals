using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            ReturnsMiddle(a);
        }
        static void ReturnsMiddle(string a)
        {
            char[] arrayA = a.ToCharArray();
            if (arrayA.Length % 2 == 0)
            {
                Console.Write(arrayA[(arrayA.Length / 2) - 1]);
            }
            Console.Write(arrayA[arrayA.Length / 2]);

            Console.WriteLine();
        }
    }
}
