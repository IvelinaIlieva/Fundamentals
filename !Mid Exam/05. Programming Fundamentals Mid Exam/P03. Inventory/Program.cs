using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Inventory
{
    internal class Program
    {
        static void Main()
        {
            List<string> items = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "Craft!")
            {
                string[] args = command.Split(" - ");

                string commType = args[0];

                if (commType == "Collect")
                {
                    string addItem = args[1];

                    if (!items.Contains(addItem))
                    {
                        items.Add(addItem);
                    }
                }
                else if (commType == "Drop")
                {
                    string dropItem = args[1];

                    items.Remove(dropItem);
                }
                else if (commType == "Combine Items")
                {
                    string[] itemsToCombine = args[1].Split(":");
                    string oldItem = itemsToCombine[0];
                    string newItem = itemsToCombine[1];

                    if (items.Contains(oldItem))
                    {
                        items.Insert(items.IndexOf(oldItem) + 1, newItem);
                    }
                }
                else if (commType == "Renew")
                {
                    string renewItem = args[1];

                    if (items.Contains(renewItem))
                    {
                        items.Remove(renewItem);
                        items.Add(renewItem);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", items));
        }
    }
}
