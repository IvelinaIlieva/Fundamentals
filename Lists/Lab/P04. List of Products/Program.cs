using System;
using System.Collections.Generic;

namespace P04._List_of_Products
{
    internal class Program
    {
        static void Main()
        {
            int countOfProducts = int.Parse(Console.ReadLine());

            List<string> productsList = new List<string>();

            for (int i = 0; i < countOfProducts; i++)
            {
                string productName = Console.ReadLine();

                productsList.Add(productName);
            }

            productsList.Sort();

            for (int i = 1; i <= productsList.Count; i++)
            {
                Console.WriteLine($"{i}.{productsList[i-1]}");
            }
        }
    }
}
