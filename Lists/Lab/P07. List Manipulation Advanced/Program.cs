using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            bool toPrint = false;

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] comArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string comType = comArgs[0];

                if (comType == "Add")
                {
                    int numberToAdd = int.Parse(comArgs[1]);
                    numbers.Add(numberToAdd);
                    toPrint = true;
                }
                else if (comType == "Remove")
                {
                    int numberToRemove = int.Parse(comArgs[1]);
                    numbers.Remove(numberToRemove);
                    toPrint = true;
                }
                else if (comType == "RemoveAt")
                {
                    int indexToRemove = int.Parse(comArgs[1]);
                    numbers.RemoveAt(indexToRemove);
                    toPrint = true;
                }
                else if (comType == "Insert")
                {
                    int numberToInsert = int.Parse(comArgs[1]);
                    int indexToInsert = int.Parse(comArgs[2]);
                    numbers.Insert(indexToInsert, numberToInsert);
                    toPrint = true;
                }
                else if (comType == "Contains")
                {
                    int numberToContain = int.Parse(comArgs[1]);

                    Console.WriteLine(numbers.Contains(numberToContain) ? "Yes" : "No such number");
                }
                else if (comType == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", numbers.FindAll(num => num % 2 == 0)));
                }
                else if (comType == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numbers.FindAll(num => num % 2 != 0)));
                }
                else if (comType == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (comType == "Filter")
                {
                    string condition = comArgs[1];
                    int numberToFilter = int.Parse(comArgs[2]);

                    if (condition == ">")
                        Console.WriteLine(string.Join(" ", numbers.FindAll(num => num > numberToFilter)));
                    else if (condition == "<")
                        Console.WriteLine(string.Join(" ", numbers.FindAll(num => num < numberToFilter)));
                    else if (condition == ">=")
                        Console.WriteLine(string.Join(" ", numbers.FindAll(num => num >= numberToFilter)));
                    else if (condition == "<=") Console.WriteLine(string.Join(" ", numbers.FindAll(num => num <= numberToFilter)));
                }
            }

            if (toPrint)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
