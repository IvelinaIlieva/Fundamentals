using System;
using System.Linq;

namespace P02.ArrayModifier
{
    internal class Program
    {
        static void Main()
        {
            int[] inputArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] comArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string commType = comArgs[0];

                if (commType == "swap")
                {
                    int index1 = int.Parse(comArgs[1]);
                    int index2 = int.Parse(comArgs[2]);

                    Swap(index1, index2, inputArr);
                }
                else if (commType == "multiply")
                {
                    int index1 = int.Parse(comArgs[1]);
                    int index2 = int.Parse(comArgs[2]);

                    Multiply(index1, index2, inputArr);
                }
                else if (commType == "decrease")
                {
                    Decrease(inputArr);
                }
            }

            Console.WriteLine(string.Join(", ", inputArr));
        }

        static int[] Swap(int index1, int index2, int[] input)
        {
            int currNum = 0;

            currNum = input[index1];
            input[index1] = input[index2];
            input[index2] = currNum;

            return input;
        }

        static int[] Multiply(int index1, int index2, int[] input)
        {
            input[index1] *= input[index2]; 
            
            return input;
        }

        static int[] Decrease(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i]--;
            }

            return input;
        }
    }
}
