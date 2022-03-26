using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] message = Console.ReadLine().Split('|').ToArray();
            char [] firstPart = message[0].ToArray();

            for (int i = 0; i < firstPart.Length; i++)
            {
                if (firstPart[i])
                {

                }
            }
        }
    }
}
