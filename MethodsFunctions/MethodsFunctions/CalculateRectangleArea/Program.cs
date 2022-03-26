using System;

namespace CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int area = RetunsArea(width, length);
            Console.WriteLine(area);
        }
        public static int RetunsArea(int width, int length)
        {
            int area = width * length;
            return area;
        }
    }
}
