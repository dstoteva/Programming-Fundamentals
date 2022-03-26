using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = ReturnsPowerResult(number, power);
            Console.WriteLine(result);
        }
        public static double ReturnsPowerResult(double num, int pow)
        {
            double result = Math.Pow(num, pow);
            return result;
        }
    }
}
