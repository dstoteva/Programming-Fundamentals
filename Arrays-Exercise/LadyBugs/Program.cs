using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] field = new int[length];
            int[] startLadyBugs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < startLadyBugs.Length; j++)
                {
                    if (i == startLadyBugs[j])
                    {
                        field[i] = 1;
                    }
                }
            }
            int takeLadyBugFrom = -1;
            int moveLadyBug = -1;
            string direction = " ";

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] command = new string[3];
                command = input.Split();

                takeLadyBugFrom = int.Parse(command[0]);
                moveLadyBug = int.Parse(command[2]);
                direction = command[1];

                if (takeLadyBugFrom < length && takeLadyBugFrom >= 0 && field[takeLadyBugFrom] == 1)
                {
                    field[takeLadyBugFrom] = 0;

                    if (direction == "right" && takeLadyBugFrom + moveLadyBug < length && takeLadyBugFrom + moveLadyBug >= 0)
                    {

                        for (int i = takeLadyBugFrom + moveLadyBug; i < length; i += moveLadyBug)
                        {
                            if (field[i] == 0)
                            {
                                field[i] = 1;
                                break;
                            }
                        }

                    }
                    else if (direction == "left" && takeLadyBugFrom - moveLadyBug >= 0 && takeLadyBugFrom - moveLadyBug < length)
                    {
                        for (int i = takeLadyBugFrom - moveLadyBug; i >= 0; i -= moveLadyBug)
                        {
                            if (field[i] == 0)
                            {
                                field[i] = 1;
                                break;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
