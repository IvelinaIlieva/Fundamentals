using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Numbers
{
    internal class Program
    {
        static void Main()
        {
            List<int> inputList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "Finish")
            {
                string[] args = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string commType = args[0];

                if (commType == "Add")
                {
                    int numToAdd= int.Parse(args[1]);

                    inputList.Add(numToAdd);
                }
                else if (commType == "Remove")
                {
                    int numToRemove = int.Parse(args[1]);

                    inputList.Remove(numToRemove);
                }
                else if (commType == "Replace")
                {
                    int numToReplace = int.Parse(args[1]);
                    int replacementNum = int.Parse(args[2]);

                    if (inputList.Contains(numToReplace))
                    {
                        inputList[inputList.IndexOf(numToReplace)] = replacementNum;
                    }
                }
                else if (commType == "Collapse")
                {
                    int collapseValue = int.Parse(args[1]);

                    inputList.RemoveAll(num => num < collapseValue);
                }
            }

            Console.WriteLine(string.Join(" ", inputList));
        }
    }
}
