using System;
using System.Reflection.Metadata.Ecma335;

namespace P01.ComputerStore
{
    internal class Program
    {
        static void Main()
        {
            decimal totalSum = 0;
            string command = Console.ReadLine();

            while (command != "special" && command != "regular")
            {
                decimal priceOfPart = decimal.Parse(command);

                if (priceOfPart <= 0)
                {
                    Console.WriteLine("Invalid price!");
                    command = Console.ReadLine();
                    continue;
                }

                totalSum += priceOfPart;
                command = Console.ReadLine();
            }

            if (totalSum == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            else
            {
                decimal taxes = totalSum * 0.2m;
                
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalSum:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                if (command == "special")
                {
                    totalSum = (totalSum + taxes) * 0.9m;
                }
                else
                {
                    totalSum += taxes;
                }

                Console.WriteLine($"Total price: {totalSum:f2}$");
            }
        }
    }
}
