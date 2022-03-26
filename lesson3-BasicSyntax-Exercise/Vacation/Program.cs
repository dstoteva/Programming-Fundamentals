using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            double pricePerPerson = 0;
            double totalPrice = 0;

            if (day == "Friday")
            {
                if (groupType == "Students")
                {
                    pricePerPerson = 8.45;
                    totalPrice = number * pricePerPerson;
                    if (number >= 30)
                    {
                        totalPrice = totalPrice * 0.85;
                    }
                }
                else if (groupType == "Business")
                {
                    pricePerPerson = 10.9;
                    totalPrice = number * pricePerPerson;
                    if (number >= 100)
                    {
                        totalPrice = (number - 10) * pricePerPerson;
                    }
                }
                else if (groupType == "Regular")
                {
                    pricePerPerson = 15;
                    totalPrice = number * pricePerPerson;
                    if (number >= 10 && number <= 20)
                    {
                        totalPrice = totalPrice * 0.95;
                    }
                }
            }
            else if (day == "Saturday")
            {
                if (groupType == "Students")
                {
                    pricePerPerson = 9.8;
                    totalPrice = number * pricePerPerson;
                    if (number >= 30)
                    {
                        totalPrice = totalPrice * 0.85;
                    }
                }
                else if (groupType == "Business")
                {
                    pricePerPerson = 15.6;
                    totalPrice = number * pricePerPerson;
                    if (number >= 100)
                    {
                        totalPrice = (number - 10) * pricePerPerson;
                    }
                }
                else if (groupType == "Regular")
                {
                    pricePerPerson = 20;
                    totalPrice = number * pricePerPerson;
                    if (number >= 10 && number <= 20)
                    {
                        totalPrice = totalPrice * 0.95;
                    }
                }
            }
            else if (day == "Sunday")
            {
                if (groupType == "Students")
                {
                    pricePerPerson = 10.46;
                    totalPrice = number * pricePerPerson;
                    if (number >= 30)
                    {
                        totalPrice = totalPrice * 0.85;
                    }
                }
                else if (groupType == "Business")
                {
                    pricePerPerson = 16;
                    totalPrice = number * pricePerPerson;
                    if (number >= 100)
                    {
                        totalPrice = (number - 10) * pricePerPerson;
                    }
                }
                else if (groupType == "Regular")
                {
                    pricePerPerson = 22.5;
                    totalPrice = number * pricePerPerson;
                    if (number >= 10 && number <= 20)
                    {
                        totalPrice = totalPrice * 0.95;
                    }
                }
            }
            Console.WriteLine("Total price: {0:f2}", totalPrice);
        }
    }
}
