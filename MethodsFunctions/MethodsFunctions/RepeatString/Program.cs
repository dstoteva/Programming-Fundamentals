using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string someString = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(ReturnString(someString, n));
        }
        static string ReturnString(string s, int n)
        {
            string newString = s;
            for (int i = 0; i < n - 1; i++)
            {
                newString += s;
            }
            return newString;
        }
    }
}
