using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            var random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                var rI = random.Next(0, input.Length);
                var temp = input[i];
                input[i] = input[rI];
                input[rI] = temp;
            }
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}
