using System;
using System.Linq;

namespace P02.ShootForTheWin
{
    internal class Program
    {
        static void Main()
        {
            int[] targetsInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int shotCounter = 0;

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                int shotIndex = int.Parse(command);

                if (shotIndex >= 0 && shotIndex < targetsInput.Length && targetsInput[shotIndex] != -1)
                {
                    int valueIndex = targetsInput[shotIndex];
                    targetsInput[shotIndex] = -1;
                    shotCounter++;

                    for (int i = 0; i < targetsInput.Length; i++)
                    {
                        if (targetsInput[i] > valueIndex)
                        {
                            targetsInput[i] -= valueIndex;
                        }
                        else if (targetsInput[i] <= valueIndex && targetsInput[i] != -1)
                        {
                            targetsInput[i] += valueIndex;
                        }
                    }
                }
            }

            Console.WriteLine($"Shot targets: {shotCounter} -> {string.Join(" ", targetsInput)}");
        }
    }
}
