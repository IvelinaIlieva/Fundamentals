using System;

namespace P01._Burger_Bus
{
    internal class Program
    {
        static void Main()
        {
            int numberOfCities = int.Parse(Console.ReadLine());

            decimal totalProfit = 0;

            for (int i = 1; i <= numberOfCities; i++)
            {
                string townName = Console.ReadLine();
                decimal incomes = decimal.Parse(Console.ReadLine());
                decimal expenses = decimal.Parse(Console.ReadLine());

                if (i % 5 == 0)
                {
                    incomes *= 0.9m;
                }
                else if (i % 3 == 0)
                {
                    if (i % 5 != 0)
                    {
                        expenses *= 1.5m;
                    }
                }

                decimal profit = incomes - expenses;
                totalProfit += profit;

                Console.WriteLine($"In {townName} Burger Bus earned {profit:f2} leva.");
            }

            Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");
        }
    }
}
