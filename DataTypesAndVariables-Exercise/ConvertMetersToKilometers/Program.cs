using System;

namespace ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            float kilometers = (float)meters / 1000;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
