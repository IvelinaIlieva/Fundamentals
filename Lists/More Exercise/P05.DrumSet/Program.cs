using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.DrumSet
{
    internal class Program
    {
        static void Main()
        {
            double savings = double.Parse(Console.ReadLine());

            List<int> drumSet = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> workingList = new List<int>();

            foreach (int price in drumSet)
            {
                workingList.Add(price);
            }

            string command;
            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);

                for (int i = 0; i < workingList.Count; i++)
                {
                    workingList[i] -= hitPower;

                    if (workingList[i] <= 0)
                    {
                        if (savings >= drumSet[i] * 3)
                        {
                            workingList[i] = drumSet[i];
                            savings-= drumSet[i]*3;
                        }
                        else
                        {
                            workingList.RemoveAt(i);
                            drumSet.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", workingList));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
