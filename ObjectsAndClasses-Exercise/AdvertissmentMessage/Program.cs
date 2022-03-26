using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertissmentMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            Random random = new Random();
            for (int i = 0; i < times; i++)
            {
                string phrase = " ";
                string eventOf = " ";
                string author = " ";
                string city = " ";
                
                for (int j = 0; j < phrases.Length; j++)
                {
                    phrase = phrases[random.Next(j)];
                }
                for (int k = 0; k < events.Length; k++)
                {
                    eventOf = events[random.Next(k)];
                }
                for (int l = 0; l < authors.Length; l++)
                {
                    author = authors[random.Next(l)];
                }
                for (int k = 0; k < cities.Length; k++)
                {
                    city = cities[random.Next(k)];
                }
                Console.WriteLine($"{phrase} {eventOf} {author} – {city}");
            }
        }
    }
}
