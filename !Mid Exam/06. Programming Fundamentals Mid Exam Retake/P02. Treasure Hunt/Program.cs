using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Treasure_Hunt
{
    internal class Program
    {
        static void Main()
        {
            List<string> items = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "Yohoho!")
            {
                string[] args = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string commType = args[0];

                if (commType == "Loot")
                {
                    for (int i = 1; i < args.Length; i++)
                    {
                        if (!items.Contains(args[i]))
                        {
                            items.Insert(0, args[i]);
                        }
                    }
                }
                else if (commType == "Drop")
                {
                    int indexToRemove = int.Parse(args[1]);

                    if (indexToRemove >= 0 && indexToRemove < items.Count)
                    {
                        string valueOfIndex = items[indexToRemove];
                        items.RemoveAt(indexToRemove);
                        items.Add(valueOfIndex);
                    }
                }
                else if (commType == "Steal")
                {
                    int count = int.Parse(args[1]);

                    if (items.Count < count)
                    {
                        count = items.Count;
                    }

                    List<string> stolenItems = new List<string>();

                    stolenItems = items.GetRange(items.Count - count, count);
                    items.RemoveRange(items.Count - count, count);

                    Console.WriteLine(string.Join(", ", stolenItems));
                }
            }

            if (items.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double sumOfLenghts = 0;

                foreach (string item in items)
                {
                    sumOfLenghts += item.Length;
                }

                double averageGain = sumOfLenghts / items.Count;

                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }
        }
    }
}
