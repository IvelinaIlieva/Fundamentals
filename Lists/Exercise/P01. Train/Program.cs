using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Train
{
    internal class Program
    {
        static void Main()
        {
            List<int> wagonWithPassengers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());
            int indexToFill = 0;

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] comArgs = command.Split().ToArray();

                if (comArgs.Length == 2)
                {
                    int addWagonWithPassengers = int.Parse(comArgs[1]);
                    wagonWithPassengers.Add(addWagonWithPassengers);
                }
                else if (comArgs.Length == 1)
                {
                    int passengersToAdd = int.Parse(comArgs[0]);

                    for (int i = 0; i < wagonWithPassengers.Count; i++)
                    {
                        if (wagonWithPassengers[i] + passengersToAdd <= maxCapacity)
                        {
                            wagonWithPassengers[i] += passengersToAdd;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagonWithPassengers));
        }
    }
}
