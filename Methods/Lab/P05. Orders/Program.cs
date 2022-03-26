using System;

namespace P05._Orders
{
    internal class Program
    {
        static void Main()
        {
            string drink = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double area = CalculatePrice(drink, quantity);
            Console.WriteLine($"{area}");
        }
        static double CalculatePrice (string drink, int quantity)
        {
            double price = 0.00;
            switch (drink)
            {
                case "coffee":
                    price = 1.5;
                    break;
                case "water":
                    price = 1;
                    break;
                case "coke":
                    price = 1.4;
                    break;
                case "snacks":
                    price = 2;
                    break;
            }
            return price * quantity;
        }
    }
}
