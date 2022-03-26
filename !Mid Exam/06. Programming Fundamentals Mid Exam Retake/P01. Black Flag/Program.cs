using System;

namespace P01._Black_Flag
{
    internal class Program
    {
        static void Main()
        {
            int daysOfPlunder = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double totalPlunder = 0;

            for (int i = 1; i <= daysOfPlunder; i++)
            {
                totalPlunder += dailyPlunder;

                if (i % 3 == 0)
                {
                    totalPlunder += dailyPlunder * 0.5;
                }

                if (i % 5 == 0)
                {
                    totalPlunder *= 0.7;
                }
            }

            Console.WriteLine(totalPlunder >= expectedPlunder
                ? $"Ahoy! {totalPlunder:f2} plunder gained."
                : $"Collected only {(totalPlunder / expectedPlunder) * 100:f2}% of the plunder.");
        }
    }
}
