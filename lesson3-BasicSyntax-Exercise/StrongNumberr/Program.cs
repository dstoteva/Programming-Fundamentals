using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongNumberr
{
    class Program
    {
        static void Main(string[] args)
        {
            int intNum = int.Parse(Console.ReadLine());
            string stringNum = intNum.ToString();
            char [] number = stringNum.ToCharArray();
            

            int fact = 1;
            int product = 0;

            for (int i = 0; i < number.Length ; i++)
            {
                int n = (int)char.GetNumericValue(number[i]);
                fact = 1;
                for (int j = 1; j <= n ; j++)
                {
                    
                    fact *= j;
                }
                product += fact;
            }

            
            
            if (intNum == product)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
