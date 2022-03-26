using System;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine();
            var second = Console.ReadLine();
            var third = Console.ReadLine();

            var all = first + second + third;
            Console.WriteLine(all);
        }
    }
}
