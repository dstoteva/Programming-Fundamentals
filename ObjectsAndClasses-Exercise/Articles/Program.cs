using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles
{

    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
            string title = input[0];
            string content = input[1];
            string author = input[2];

            Article currentArticle = new Article(title, content, author);

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string [] currentInput = Console.ReadLine().Split(new string[] { ": " }, StringSplitOptions.None);
                string command = currentInput[0];

                if (command == "Edit")
                {
                    string newContent = currentInput[1];
                    currentArticle.Edit(newContent);
                }
                else if (command == "ChangeAuthor")
                {
                    string newAuthor = currentInput[1];
                    currentArticle.ChangeAuthor(newAuthor);
                }
                else if (command == "Rename")
                {
                    string newTitle = currentInput[1];
                    currentArticle.Rename(newTitle);
                }
            }
            Console.WriteLine(currentArticle);
        }
    }
}
