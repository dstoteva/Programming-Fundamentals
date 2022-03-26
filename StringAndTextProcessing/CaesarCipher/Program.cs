using System;
using System.Collections.Generic;
using System.Linq;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                char current = (char)(input[i] + 3);
                result += current;
            }
            Console.WriteLine(result);
        }
    }
}
