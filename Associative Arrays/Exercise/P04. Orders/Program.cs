using System;
using System.Collections.Generic;

namespace P04._Orders
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string,double> productAndPrice = new Dictionary<string,double>();
            Dictionary<string,int> productAndQuantity = new Dictionary<string,int>();

            string command;
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] productArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string productName = productArgs[0];
                double productPrice = double.Parse(productArgs[1]);
                int productQuantity = int.Parse(productArgs[2]);

                if (!productAndPrice.ContainsKey(productName))
                {
                    productAndPrice[productName] = 0;
                    productAndQuantity[productName] = 0;
                }

                productAndPrice[productName] = productPrice;
                productAndQuantity[productName] += productQuantity;
            }

            foreach (var kvp in productAndPrice)
            {
                double totalPrice = kvp.Value * productAndQuantity[kvp.Key];

                Console.WriteLine($"{kvp.Key} -> {totalPrice:f2}");
            }
        }
    }
}
