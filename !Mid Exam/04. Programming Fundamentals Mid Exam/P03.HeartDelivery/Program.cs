using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.HeartDelivery
{
    internal class Program
    {
        static void Main()
        {
            const int HeartEnergy = 2;
            int[] neighborhood = Console.ReadLine()
                .Split('@', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int currIndex = 0;
            string command;
            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] args = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int indexToJump = int.Parse(args[1]);

                if (currIndex + indexToJump >= neighborhood.Length)
                {
                    currIndex = 0;
                }
                else
                {
                    currIndex += indexToJump;
                }
                
                if (neighborhood[currIndex] == 0)
                {
                    Console.WriteLine($"Place {currIndex} already had Valentine's day.");
                    continue;
                }
                else if (neighborhood[currIndex] >= HeartEnergy)
                {
                    neighborhood[currIndex] -= HeartEnergy;

                    if (neighborhood[currIndex] == 0)
                    {
                        Console.WriteLine($"Place {currIndex} has Valentine's day.");
                    }
                }
            }

            Console.WriteLine($"Cupid's last position was {currIndex}.");

            if (neighborhood.ToList().Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                List<int> failedList = neighborhood.ToList().FindAll(num => num > 0);
                Console.WriteLine($"Cupid has failed {failedList.Count} places.");
            }
        }
    }
}
