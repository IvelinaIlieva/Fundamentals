using System;

namespace P09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int expectedYield = startingYield;
            int storage = 0;
            int countOfDays = 0;

            while (expectedYield >= 100)
            {
                countOfDays++;
                storage += expectedYield;
                storage -= 26;
                expectedYield -= 10;
            }
            if (storage >= 26)
            {
                storage -= 26;
            }
            Console.WriteLine(countOfDays);
            Console.WriteLine(storage);
        }
    }
}
