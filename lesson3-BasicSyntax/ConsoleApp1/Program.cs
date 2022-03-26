using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd.M.yyyy", CultureInfo.InvariantCulture);

            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd.M.yyyy", CultureInfo.InvariantCulture);

            var holidaysCount = 0;
            var date = startDate;

            //for (var date = startDate; date <= endDate; date = date.AddDays(1))

            do
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
                date = date.AddDays(1);
            } while (date>=startDate && date<=endDate);
            
            Console.WriteLine(holidaysCount);
        }
    }
}
