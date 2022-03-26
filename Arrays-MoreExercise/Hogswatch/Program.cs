using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogswatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int homes = int.Parse(Console.ReadLine());
            int presents = int.Parse(Console.ReadLine());

            int presentsLeft = presents;
            int additionalPresents = 0;
            int timesBack = 0;
            bool areEnought = true;
            int totalAdditional = 0;
            for (int i = 0; i < homes; i++)
            {
                int children = int.Parse(Console.ReadLine());
                if (presentsLeft - children >= 0)
                {
                    presentsLeft -= children;
                }
                else
                {
                    areEnought = false;
                    timesBack++;
                    additionalPresents = (presents / (i + 1)) * (homes - (i + 1)) + (children - presentsLeft);
                    totalAdditional += additionalPresents;
                    presentsLeft += additionalPresents;
                    presentsLeft -= children;
                }
            }
            if (areEnought)
            {
                Console.WriteLine(presentsLeft);
            }
            else
            {
                Console.WriteLine(timesBack);
                Console.WriteLine(totalAdditional);
            }
        }
    }
}
