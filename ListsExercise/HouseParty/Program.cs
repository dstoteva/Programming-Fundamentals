using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> going = new List<string>();

            for (int i = 0; i < n; i++)
            {
                List<string> guest = Console.ReadLine().Split().ToList();
                string name = guest[0];

                if (guest[2] == "going!")
                {
                    if (going.Count > 0)
                    {
                        bool isIn = false;
                        for (int j = 0; j < going.Count; j++)
                        {
                            if (name == going[j])
                            {
                                Console.WriteLine($"{name} is already in the list!");
                                isIn = true;
                                break;
                            }
                        }
                        if (isIn == false)
                        {
                            going.Add(name);
                        }
                    }
                    else
                    {
                        going.Add(name);
                    }
                }
                else if (guest[2] == "not")
                {
                    if (going.Count > 0)
                    {
                        for (int k = 0; k < going.Count; k++)
                        {
                            if (name == going[k])
                            {
                                going.RemoveAt(k);
                                break;
                            }
                            else if (k == going.Count - 1)
                            {
                                Console.WriteLine($"{name} is not in the list!");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            for (int i = 0; i < going.Count; i++)
            {
                Console.WriteLine(going[i]);
            }
        }
    }
}
