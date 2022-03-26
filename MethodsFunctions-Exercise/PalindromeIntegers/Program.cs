using System;
using System.Linq;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string a = Console.ReadLine();
                if (a == "END")
                {
                    break;
                }
                if (IsPolindrome(a))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            
        }
        static bool IsPolindrome(string a)
        {
            bool isPolindrome = false;
            char[] nums = a.ToCharArray();
            for (int i = 0; i < nums.Length / 2; i++)
            {
                if (nums[i] ==  nums[nums.Length - i - 1])
                {
                    isPolindrome = true;

                }
                else
                {
                    isPolindrome = false;
                    break;
                }
            }
            return isPolindrome;
        }
    }
}
