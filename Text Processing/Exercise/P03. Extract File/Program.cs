using System;
using System.Linq;

namespace P03._Extract_File
{
    internal class Program
    {
        static void Main()
        {
            string lastElement = Console.ReadLine().Split('\\').Last();

            string fileName = lastElement.Substring(0, lastElement.LastIndexOf('.'));
            string extension = lastElement.Substring(lastElement.LastIndexOf('.') + 1);            

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
