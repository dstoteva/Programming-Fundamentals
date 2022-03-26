using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishNameOfTheLastDigit_Method
{
    class Program
    {
        static void LastDigitEnglishName (string digits)
        {        
            char[] digitsToCharArray = digits.ToCharArray();
            int n = (int)char.GetNumericValue(digitsToCharArray[digits.Length - 1]);

            string lastName = "";

            switch (n)
            {
                case 1:
                    lastName = "one";
                    break;
                case 2:
                    lastName = "two";
                    break;
                case 3:
                    lastName = "three";
                    break;
                case 4:
                    lastName = "four";
                    break;
                case 5:
                    lastName = "five";
                    break;
                case 6:
                    lastName = "six";
                    break;
                case 7:
                    lastName = "seven";
                    break;
                case 8:
                    lastName = "eight";
                    break;
                case 9:
                    lastName = "nine";
                    break;
                case 0:
                    lastName = "zero";
                    break;
                default:
                    break;
            }
            Console.WriteLine(lastName);
        }
        static void Main(string[] args)
        {
            string digits = Console.ReadLine();
            LastDigitEnglishName(digits);
        }
    }
}
