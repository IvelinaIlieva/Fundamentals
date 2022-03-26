using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.MemoryGame
{
    internal class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int counter = 0;
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                int[] indexes = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                counter++;
                
                if (toAdd(indexes[0], indexes[1], input))
                {
                    string addSymbols = "-" + counter + "a";
                    input.Insert(input.Count / 2, addSymbols);
                    input.Insert(input.Count / 2, addSymbols);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }

                if (input[indexes[0]] == input[indexes[1]])
                {
                    string element = input[indexes[0]];
                    if (indexes[0] > indexes[1])
                    {
                        input.RemoveAt(indexes[0]);
                        input.RemoveAt(indexes[1]);
                    }
                    else
                    {
                        input.RemoveAt(indexes[1]);
                        input.RemoveAt(indexes[0]);
                    }

                    Console.WriteLine($"Congrats! You have found matching elements - {element}!");
                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                if (input.Count == 0)
                {
                    Console.WriteLine($"You have won in {counter} turns!");
                    return;
                }
            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", input));
        }

        static bool toAdd(int index1, int index2, List<string> input)
        {
            if (index1 == index2)
            {
                return true;
            }
            else if (index1 < 0)
            {
                return true;
            }
            else if (index1 >= input.Count)
            {
                return true;
            }
            else if (index2 < 0)
            {
                return true;
            }
            else if (index2 >= input.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
