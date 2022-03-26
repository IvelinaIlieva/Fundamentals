using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._List_Operations
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string typeOfCommand = commArgs[0];

                switch (typeOfCommand)
                {
                    case "Add":
                        int numToAdd = int.Parse(commArgs[1]);
                        numbers.Add(numToAdd);
                        break;

                    case "Insert":
                        int numToInsert = int.Parse(commArgs[1]);
                        int indexToInsert = int.Parse(commArgs[2]);

                        if (indexToInsert < 0 || indexToInsert >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        numbers.Insert(indexToInsert, numToInsert);
                        break;

                    case "Remove":
                        int indexToRemove = int.Parse(commArgs[1]);

                        if (indexToRemove < 0 || indexToRemove >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        numbers.RemoveAt(indexToRemove);
                        break;

                    case "Shift":
                        string direction = commArgs[1];
                        int count = int.Parse(commArgs[2]);
                        int realCount = count % numbers.Count;
                        int currNum;

                        for (int i = 0; i < realCount; i++)
                        {
                            if (direction == "left")
                            {
                                currNum = numbers[0];
                                numbers.RemoveAt(0);
                                numbers.Add(currNum);
                            }
                            else if (direction == "right")
                            {
                                currNum = numbers[numbers.Count - 1];
                                numbers.RemoveAt(numbers.Count - 1);
                                numbers.Insert(0, currNum);
                            }
                        }
                        break;

                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
