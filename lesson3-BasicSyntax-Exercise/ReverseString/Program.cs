using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] output = input.ToCharArray();
            Array.Reverse(output);

            Console.WriteLine(output);
        }
    }
}
