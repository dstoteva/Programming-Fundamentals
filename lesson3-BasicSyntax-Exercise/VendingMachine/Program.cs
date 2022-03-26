using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            
            decimal pricePerProduct = 0;
            decimal moneyIn = 0;
            

            string coin = Console.ReadLine();

            while (coin != "Start")
            {
                
                switch (coin)
                {
                    case "0.1":
                    case "0.2":
                    case "0.5":
                    case "1":
                    case "2":
                        moneyIn = moneyIn + decimal.Parse(coin);
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coin}");
                        break;
                }
                coin = Console.ReadLine();
            }
            string product = Console.ReadLine();
            while (product != "End")
            {  
                    switch (product)
                    {
                        case "Nuts":
                            pricePerProduct = 2;
                            
                            break;
                        case "Water":
                            pricePerProduct = 0.7m;
                            
                            break;
                        case "Crisps":
                            pricePerProduct = 1.5m;
                            
                            break;
                        case "Soda":
                            pricePerProduct = 0.8m;
                            
                            break;
                        case "Coke":
                            pricePerProduct = 1m;
                            
                            break;
                        default:
                        Console.WriteLine("Invalid product");
                            break;
                    }
                
                if (moneyIn - pricePerProduct >= 0 && pricePerProduct > 0)
                {
                    moneyIn -= pricePerProduct;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else if (moneyIn - pricePerProduct < 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                product = Console.ReadLine();
            }
            Console.WriteLine("Change: {0:f2}", moneyIn);
        }
    }
}
