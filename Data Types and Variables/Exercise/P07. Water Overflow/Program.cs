using System;

namespace P07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte countOfPour = byte.Parse(Console.ReadLine());

            int totalWaterInTank = 0;
            const int TankCapacity = 255;

            for (int i = 0; i < countOfPour; i++)
            {
                int pouredWater = int.Parse(Console.ReadLine());

                if (totalWaterInTank + pouredWater > TankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    totalWaterInTank += pouredWater;
                }
            }
            Console.WriteLine(totalWaterInTank);
        }
    }
}
