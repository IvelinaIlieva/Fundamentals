using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.MovingTarget
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
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string commType = commArgs[0];

                switch (commType)
                {
                    case "Shoot":
                        int shootIndex = int.Parse(commArgs[1]);
                        int shotPower = int.Parse(commArgs[2]);

                        Shoot(inputList, shootIndex, shotPower);

                        break;
                    case "Add":
                        int insertIndex = int.Parse(commArgs[1]);
                        int insertValue = int.Parse(commArgs[2]);

                        Add(inputList, insertIndex, insertValue);

                        break;
                    case "Strike":
                        int strikeIndex = int.Parse(commArgs[1]);
                        int radius = int.Parse(commArgs[2]);

                        Strike(inputList, strikeIndex, radius);

                        break;
                }
            }

            Console.WriteLine(string.Join("|", inputList));
        }

        static bool IsValid(List<int> input, int index)
        {
            if (index >= 0 && index < input.Count)
            {
                return true;
            }
            return false;
        }

        static void Shoot(List<int> input, int index, int power)
        {
            if (IsValid(input, index))
            {
                input[index] -= power;

                if (input[index] <= 0)
                {
                    input.RemoveAt(index);
                }
            }
        }

        static void Add(List<int> input, int index, int value)
        {
            if (IsValid(input, index))
            {
                input.Insert(index, value);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }
        }

        static void Strike(List<int> input, int index, int radius)
        {
            if (IsValid(input, index)
                && IsValid(input, index - radius)
                && IsValid(input, index + radius))
            {
                input.RemoveRange(index - radius, 2 * radius + 1);
            }
            else
            {
                Console.WriteLine("Strike missed!");
            }
        }
    }
}
