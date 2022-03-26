﻿using System;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] forbidden = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var word in forbidden)
            {
                var replacement = new string('*', word.Length);
                text = text.Replace(word, replacement);
            }
            Console.WriteLine(text);
        }
    }
}
