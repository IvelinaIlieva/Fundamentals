using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P01._Furniture
{
    internal class Program
    {
        static void Main()
        {
            List<string> furnitureName = new List<string>();
            double totalPrice = 0;

            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)";

                Match purchaseInfo = Regex.Match(input, pattern);

                if (purchaseInfo.Success)
                {
                    string name = purchaseInfo.Groups["name"].Value;
                    furnitureName.Add(name);

                    double price = double.Parse(purchaseInfo.Groups["price"].Value);
                    int quantity = int.Parse(purchaseInfo.Groups["quantity"].Value);

                    totalPrice += price * quantity;
                }
            }

            Console.WriteLine("Bought furniture:");

            foreach (string name in furnitureName)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
