using System;
using System.Text.RegularExpressions;

namespace P03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main()
        {
            double totalIncome = 0;

            string input;
            while ((input=Console.ReadLine()) != "end of shift")
            {
                string pattern = @"\%(?<customer>[A-Z]{1}[a-z]+)\%[^\|\$\%\.]*?\<(?<product>\w+)\>[^\|\$\%\.]*?\|(?<count>\d+)\|[^\|\$\%\.]*?(?<price>\d+(\.\d+)?)\$";

                Match purchase = Regex.Match(input, pattern);

                if (purchase.Success)
                {
                    string customer = purchase.Groups["customer"].Value;
                    string product = purchase.Groups["product"].Value;
                    int count = int.Parse(purchase.Groups["count"].Value);
                    double price = double.Parse(purchase.Groups["price"].Value);

                    double totalPrice = price * count;
                    totalIncome+=totalPrice;

                    Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
