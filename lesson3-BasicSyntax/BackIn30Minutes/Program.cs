using System;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int timeInMinutes = hours * 60 + minutes + 30;

            int newHours = timeInMinutes / 60;
            int newMinutes = timeInMinutes % 60;

            if (newHours>23)
            {
                newHours = 0;
            }
            if (newMinutes>59)
            {
                newMinutes = newMinutes - 60;
            }
            if (newMinutes>=0 && newMinutes < 10)
            {
                Console.WriteLine($"{newHours}:0{newMinutes}");
            }
            else
            {
                Console.WriteLine($"{newHours}:{newMinutes}");
            }
        }
    }
}
