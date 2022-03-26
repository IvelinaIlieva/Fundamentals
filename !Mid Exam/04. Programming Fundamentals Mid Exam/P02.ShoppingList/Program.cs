using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.ShoppingList
{
    internal class Program
    {
        static void Main()
        {
            List<string> shoppingList = Console.ReadLine()
                .Split('!', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] args = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string commType = args[0];

                if (commType == "Urgent")
                {
                    string newItem = args[1];

                    if (!shoppingList.Contains(newItem))
                    {
                        shoppingList.Insert(0, newItem);
                    }
                }
                else if (commType == "Unnecessary")
                {
                    string unnecessaryItem = args[1];

                    shoppingList.Remove(unnecessaryItem);
                }
                else if (commType == "Correct")
                {
                    string oldItem = args[1];
                    string newItem = args[2];

                    if (shoppingList.Contains(oldItem))
                    {
                        shoppingList[shoppingList.IndexOf(oldItem)] = newItem;
                    }
                }
                else if (commType == "Rearrange")
                {
                    string reverseItem = args[1];

                    if (shoppingList.Contains(reverseItem))
                    {
                        shoppingList.Remove(reverseItem);
                        shoppingList.Add(reverseItem);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", shoppingList));
        }
    }
}
