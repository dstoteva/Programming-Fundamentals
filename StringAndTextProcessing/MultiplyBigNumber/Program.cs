using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Globalization;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine().TrimStart('0');
            int n = int.Parse(Console.ReadLine());

            string reversed = string.Join("", bigNumber.ToCharArray().Reverse());
            string answer = "";
            int leftover = 0;

            
            for (int i = 0; i < reversed.Length; i++)
            {
                int currentResult = n * int.Parse(reversed[i].ToString()) + leftover;
                leftover = 0;

                answer += currentResult % 10;
                leftover = currentResult / 10;

                if (i == reversed.Length - 1 && leftover != 0)
                {
                    answer += leftover;
                }
            }
            answer = String.Join("", answer.ToCharArray().Reverse());

            if (answer[0] == '0')
            {
                int lastIndexOfZero = answer.LastIndexOf('0');
                answer = answer.Remove(0, lastIndexOfZero + 1);
            }
            if (answer == string.Empty)
            {
                answer += '0';
            }
            Console.WriteLine(answer);
        }
    }
}
