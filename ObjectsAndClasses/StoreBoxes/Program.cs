using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> allBoxes = new List<Box>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "end")
                {
                    break;
                }

                string serialNumber = input[0];
                string item = input[1];
                int itemQuantity = int.Parse(input[2]);
                double itemPrice = double.Parse(input[3]);

                double priceOfABox = itemQuantity * itemPrice;

               Box currentBox = new Box { SerialNumber = serialNumber, Item = new Item {Name = item, Price = itemPrice }, ItemQuantity = itemQuantity, PriceForABox = priceOfABox };
                allBoxes.Add(currentBox);
            }

            var result = allBoxes.OrderByDescending(b => b.PriceForABox);
            foreach (Box box in result)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- { box.Item.Name} - ${ box.Item.Price:f2}: { box.ItemQuantity}");
                Console.WriteLine($"-- ${ box.PriceForABox:f2}");
            }
        }
    }
}
