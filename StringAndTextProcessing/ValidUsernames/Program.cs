using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();

            var validUserNames = new List<string>();

            
            foreach (var name in input)
            {
                bool passwordIsValid = false;

                if (name.Length > 3 && name.Length < 16 && !name.Contains(' '))
                {
                    
                    for (int i = 0; i < name.Length; i++)
                    {
                        
                        if (char.IsLetterOrDigit(name[i]) || name[i] == '-' || name[i] == '_')
                        {
                            passwordIsValid = true;
                        }
                        else
                        {
                            passwordIsValid = false;
                            break;
                        }
                    }
                }
                if (passwordIsValid)
                {
                    validUserNames.Add(name);
                }
            }
            foreach (var name in validUserNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
