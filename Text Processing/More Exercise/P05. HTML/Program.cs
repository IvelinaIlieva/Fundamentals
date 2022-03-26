using System;
using System.Text;

namespace P05._HTML
{
    internal class Program
    {
        static void Main()
        {
            string titleOfArticle = Console.ReadLine();
            string content = Console.ReadLine();

            StringBuilder html = new StringBuilder();
            html.AppendLine($"<h1>\n\t{titleOfArticle}\n</h1>");
            html.AppendLine($"<article>\n\t{content}\n</article>");
            
            string command;
            while ((command = Console.ReadLine()) != "end of comments")
            {
                string comment = command;

                html.AppendLine($"<div>\n\t{comment}\n</div>");
            }

            Console.WriteLine(html);
        }
    }
}
