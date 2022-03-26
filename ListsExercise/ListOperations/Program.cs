using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> line = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                List<string> currentCommand = Console.ReadLine().Split().ToList();

                string firstWord = currentCommand[0];

                if (firstWord == "End")
                {
                    break;
                }
                if (firstWord == "Add")
                {
                    int num = int.Parse(currentCommand[1]);
                    line.Add(num);
                }
                else if (firstWord == "Remove")
                {
                    int index = int.Parse(currentCommand[1]);
                    if (index < line.Count && index >= 0)
                    {
                        line.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (firstWord == "Insert")
                {
                    int num = int.Parse(currentCommand[1]);
                    int index = int.Parse(currentCommand[2]);
                    if (index < line.Count && index >= 0)
                    {
                        line.Insert(index, num);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (firstWord == "Shift")
                {
                    string secondWord = currentCommand[1];
                    int times = int.Parse(currentCommand[2]);

                    if (secondWord == "left")
                    {
                        for (int i = 0; i < times; i++)
                        {
                            int firstNum = line[0];
                            line.RemoveAt(0);
                            line.Add(firstNum);
                        }
                    }
                    else if (secondWord == "right")
                    {
                        line.Reverse();
                        for (int i = 0; i < times; i++)
                        {
                            int lastNum = line[0];
                            line.RemoveAt(0);
                            line.Add(lastNum);
                        }
                        line.Reverse();
                    }
                }
            }
            Console.WriteLine(string.Join(" ", line));
        }
    }
}
