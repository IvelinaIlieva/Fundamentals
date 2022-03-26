using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] comArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string comType = comArgs[0];

                if (comType == "Add")
                {
                    int numberToAdd = int.Parse(comArgs[1]);
                    numbers.Add(numberToAdd);
                }
                else if (comType == "Remove")
                {
                    int numberToRemove = int.Parse(comArgs[1]);
                    numbers.Remove(numberToRemove);
                }
                else if (comType == "RemoveAt")
                {
                    int indexToRemove = int.Parse(comArgs[1]);
                    numbers.RemoveAt(indexToRemove);
                }
                else if (comType == "Insert")
                {
                    int numberToInsert = int.Parse(comArgs[1]);
                    int indexToInsert = int.Parse(comArgs[2]);
                    numbers.Insert(indexToInsert, numberToInsert);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
