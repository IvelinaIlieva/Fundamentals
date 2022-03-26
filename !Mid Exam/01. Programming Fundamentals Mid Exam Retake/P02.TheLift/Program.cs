using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace P02.TheLift
{
    internal class Program
    {
        static void Main()
        {
            const int WagonCapacity = 4;

            int waitingPeople = int.Parse(Console.ReadLine());

            List<int> wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < wagons.Count; i++)
            {
                while (wagons[i] < WagonCapacity)
                {
                    wagons[i]++;
                    waitingPeople--;

                    if (waitingPeople == 0)
                    {
                        break;
                    }
                }
                if (waitingPeople == 0 && wagons.Sum() < wagons.Count * WagonCapacity)
                {
                    Console.WriteLine("The lift has empty spots!");
                    Console.WriteLine(string.Join(" ", wagons));
                    return;
                }
            }

            if (waitingPeople == 0)
            {
                Console.WriteLine(string.Join(" ", wagons));
            }
            else
            {
                Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
                Console.WriteLine(string.Join(" ", wagons));
            }
        }
    }
}
