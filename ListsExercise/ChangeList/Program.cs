using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> line = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                List <string> currentCommand = Console.ReadLine().Split().ToList();
                string command = currentCommand[0];

                if (command == "end")
                {
                    break;
                }
                int number = int.Parse(currentCommand[1]);

                if (command == "Delete")
                {
                    for (int i = 0; i < line.Count; i++)
                    {
                        if (number == line[i])
                        {
                            line.RemoveAt(i);
                        }
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(currentCommand[2]);
                    line.Insert(index, number);
                }
            }
            Console.WriteLine(string.Join(" ", line));
        }
    }
}
