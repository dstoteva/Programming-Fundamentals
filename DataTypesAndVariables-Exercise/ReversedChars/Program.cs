using System;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine();
            var second = Console.ReadLine();
            var third = Console.ReadLine();

            var all = third + " " + second + " " + first;
            Console.WriteLine(all);
        }
    }
}
