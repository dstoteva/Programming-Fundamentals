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
            bool listIsChanged = false;

            while (true)
            {
                List<string> currentLine = Console.ReadLine().Split().ToList();
                string command = currentLine[0];


                if (command == "end")
                {
                    break;
                }


                switch (command)
                {
                    case "Add":
                        line.Add(int.Parse(currentLine[1]));
                        listIsChanged = true;
                        break;
                    case "Remove":
                        line.Remove(int.Parse(currentLine[1]));
                        listIsChanged = true;
                        break;
                    case "RemoveAt":
                        line.RemoveAt(int.Parse(currentLine[1]));
                        listIsChanged = true;
                        break;
                    case "Insert":
                        line.Insert(int.Parse(currentLine[2]), int.Parse(currentLine[1]));
                        listIsChanged = true;
                        break;
                    case "Contains":
                        bool containsNumber = line.Contains(int.Parse(currentLine[1]));
                        if (containsNumber)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        List<int> even = line.Where(n => n % 2 == 0).ToList();
                        Console.WriteLine(string.Join(" ", even));
                        break;
                    case "PrintOdd":
                        List<int> odd = line.Where(n => n % 2 != 0).ToList();
                        Console.WriteLine(string.Join(" ", odd));
                        break;
                    case "GetSum":
                        long sum = 0;
                        for (int i = 0; i < line.Count; i++)
                        {
                            sum += line[i];
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        int num = int.Parse(currentLine[2]);
                        switch (currentLine[1])
                        {
                            case ">":
                                List<int> bigger = line.Where(n => n > num).ToList();
                                Console.WriteLine(string.Join(" ", bigger));
                                break;
                            case "<":
                                List<int> smaller = line.Where(n => n < num).ToList();
                                Console.WriteLine(string.Join(" ", smaller));
                                break;
                            case ">=":
                                List<int> biggerOrEqual = line.Where(n => n >= num).ToList();
                                Console.WriteLine(string.Join(" ", biggerOrEqual));
                                break;
                            case "<=":
                                List<int> smallerOrEqual = line.Where(n => n <= num).ToList();
                                Console.WriteLine(string.Join(" ", smallerOrEqual));
                                break;
                        }
                        break;
                }

            }
            if (listIsChanged)
            {
                Console.WriteLine(string.Join(" ", line));
            }

        }
    }
}
