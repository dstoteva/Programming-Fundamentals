using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            string result = GetMax(a, b);
            Console.WriteLine(result);
        }
        public static string GetMax(string a, string b)
        {
            int intA = 0;
            int intB = 0;
            char charA = ' ';
            char charB = ' ';
            bool AIsInteger = int.TryParse(a, out intA);
            bool BIsInteger = int.TryParse(b, out intB);
            bool AIsChar = char.TryParse(a, out charA);
            bool BIsChar = char.TryParse(b, out charB);

            if (AIsInteger && BIsInteger)
            {
                if (intA > intB)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            }
            else if (AIsChar && BIsChar)
            {
                if (charA > charB)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            }
            else
            {
                if (a.CompareTo(b) >= 0)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            }
        }
    }
}
