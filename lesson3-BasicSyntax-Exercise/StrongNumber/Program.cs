using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            char[] passwordChar = username.ToCharArray();
            Array.Reverse(passwordChar);
            string realPassword = new string(passwordChar);
            int count = 0;

            while (true)
            {
                string password = Console.ReadLine();
                if (realPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (realPassword != password)
                {
                    count++;
                    if (count < 4)
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }

                    else if (count == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                }
            }
        }
    }
}


