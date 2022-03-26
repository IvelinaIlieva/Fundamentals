using System;

namespace P01.CounterStrike
{
    internal class Program
    {
        static void Main()
        {
            int initialEnergy = int.Parse(Console.ReadLine());

            int winCounter = 0;
            string command;
            while ((command = Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(command);

                if (distance <= initialEnergy)
                {
                    initialEnergy -= distance;
                    winCounter++;

                    if (winCounter % 3 == 0)
                    {
                        initialEnergy += winCounter;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {winCounter} won battles and {initialEnergy} energy");
                    return;
                }
            }

            Console.WriteLine($"Won battles: {winCounter}. Energy left: {initialEnergy}");
        }
    }
}
