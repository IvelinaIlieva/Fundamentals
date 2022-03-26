using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Change_List
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

                if (comArgs[0] == "Delete")
                {
                    int elementToDel = int.Parse(comArgs[1]);
                    numbers.RemoveAll(num => num == elementToDel);
                }
                else if (comArgs[0] == "Insert")
                {
                    int elementToInsert = int.Parse(comArgs[1]);
                    int index = int.Parse(comArgs[2]);
                    numbers.Insert(index, elementToInsert);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
