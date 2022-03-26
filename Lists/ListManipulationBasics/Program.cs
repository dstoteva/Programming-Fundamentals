using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> line = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                List<string> currentLine = Console.ReadLine().Split().ToList();
                string command = currentLine[0];


                if (command == "end")
                {
                    break;
                }
                int number = int.Parse(currentLine[1]);

                switch (command)
                {
                    case "Add":
                        line.Add(number);
                        break;
                    case "Remove":
                        line.Remove(number);
                        break;
                    case "RemoveAt":
                        line.RemoveAt(number);
                        break;
                    case "Insert":
                        line.Insert(int.Parse(currentLine[2]), number);
                        break;
                }

            }
            Console.WriteLine(string.Join(" ", line));
        }
    }
}
