using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P08._Anonymous_Threat
{
    internal class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] commArgs = command.Split(" ").ToArray();

                string commType = commArgs[0];

                if (commType == "merge")
                {
                    int startIndex = int.Parse(commArgs[1]);
                    int endIndex = int.Parse(commArgs[2]);

                    Merge(input, startIndex, endIndex);
                }
                else if (commType == "divide")
                {
                    int index = int.Parse(commArgs[1]);
                    int partitions = int.Parse(commArgs[2]);

                    Divide(input, index, partitions);
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }

        static void Merge(List<string> input, int start, int stop)
        {
            if (start < 0)
            {
                start = 0;
            }
            else if (start >= input.Count)
            {
                start = input.Count - 1;
            }

            if (stop >= input.Count)
            {
                stop = input.Count - 1;
            }

            StringBuilder mergeBuilder = new StringBuilder();
            for (int i = start; i <= stop; i++)
            {
                mergeBuilder.Append(input[i]);
            }
            input.RemoveRange(start, stop - start + 1);
            input.Insert(start, mergeBuilder.ToString());
        }

        static void Divide(List<string> input, int index, int parts)
        {
            int countOfSymbols = input[index].Length / parts;
            int addSymbol = input[index].Length % parts;

            List<string> addList = new List<string>();

            for (int i = 0; i < parts; i++)
            {
                if (i == parts - 1)
                {
                    countOfSymbols += addSymbol;
                }

                addList.Add(input[index].Substring(0, countOfSymbols));
                input[index] = input[index].Remove(0, countOfSymbols);
            }
            input.RemoveAt(index);
            input.InsertRange(index, addList);
        }
    }
}
