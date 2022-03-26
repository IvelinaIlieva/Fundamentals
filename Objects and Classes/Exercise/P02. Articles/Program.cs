using System;

namespace P02._Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string content)
        {
            this.Content = content;
        }

        public void ChangeAuthor(string author)
        {
            this.Author = author;
        }

        public void Rename(string title)
        {
            this.Title = title;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
    internal class Program
    {
        static void Main()
        {
            string[] inputData = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string title = inputData[0];
            string content = inputData[1];
            string author = inputData[2];

            Article newArticle = new Article(title, content, author);

            int numberOfCommand = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfCommand; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string typeOfCommand = commandArgs[0];

                if (typeOfCommand == "Edit")
                {
                    newArticle.Edit(commandArgs[1]);
                }
                else if (typeOfCommand == "ChangeAuthor")
                {
                    newArticle.ChangeAuthor(commandArgs[1]);
                }
                else if (typeOfCommand == "Rename")
                {
                    newArticle.Rename(commandArgs[1]);
                }
            }

            Console.WriteLine(newArticle);
        }
    }
}
