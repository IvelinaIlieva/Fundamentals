using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Articles_2._0
{
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

            public override string ToString()
            {
                return $"{this.Title} - {this.Content}: {this.Author}";
            }
        }
        internal class Program
        {
            static void Main()
            {
                List<Article> listOfArticles = new List<Article>();

                int numberOfArticles = int.Parse(Console.ReadLine());

                for (int i = 1; i <= numberOfArticles; i++)
                {
                    string[] commandArgs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                    string title = commandArgs[0];
                    string content = commandArgs[1];
                    string author = commandArgs[2];

                    Article newArticle = new Article(title, content, author);
                    listOfArticles.Add(newArticle);
                }

                string orderParam = Console.ReadLine();

                switch (orderParam)
                {
                    case "title":
                        listOfArticles = listOfArticles.OrderBy(l => l.Title).ToList();
                        break;
                    case "content":
                        listOfArticles = listOfArticles.OrderBy(l => l.Content).ToList();
                        break;
                    case "author":
                        listOfArticles = listOfArticles.OrderBy(l => l.Author).ToList();
                        break;
                }

                foreach (Article article in listOfArticles)
                {
                    Console.WriteLine(article);
                }
            }
        }
    }
}
