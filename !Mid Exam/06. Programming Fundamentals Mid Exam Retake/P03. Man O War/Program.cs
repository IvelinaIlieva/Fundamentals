using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Man_O_War
{
    internal class Program
    {
        static void Main()
        {
            List<int> pirateShipStatus = Console.ReadLine()
                .Split('>', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> warShipStatus = Console.ReadLine()
                .Split('>', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxHealth = int.Parse(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "Retire")
            {
                string[] args = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string commType = args[0];

                if (commType == "Fire")
                {
                    int indexForFire = int.Parse(args[1]);
                    int damage = int.Parse(args[2]);

                    if (IsIndexValid(indexForFire, warShipStatus))
                    {
                        warShipStatus[indexForFire] -= damage;

                        if (warShipStatus[indexForFire] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                else if (commType == "Defend")
                {
                    int startIndex = int.Parse(args[1]);
                    int endIndex = int.Parse(args[2]);
                    int damage = int.Parse(args[3]);

                    if (IsIndexValid(startIndex, pirateShipStatus) && IsIndexValid(endIndex, pirateShipStatus))
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShipStatus[i] -= damage;

                            if (pirateShipStatus[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                else if (commType == "Repair")
                {
                    int indexForRepair = int.Parse(args[1]);
                    int health = int.Parse(args[2]);

                    if (IsIndexValid(indexForRepair, pirateShipStatus))
                    {
                        pirateShipStatus[indexForRepair] += health;

                        if (pirateShipStatus[indexForRepair] > maxHealth)
                        {
                            pirateShipStatus[indexForRepair] = maxHealth;
                        }
                    }
                }
                else if (commType == "Status")
                {
                    double limitToRepair = maxHealth * 0.2;

                    List<int> sectionsForRepair = pirateShipStatus.FindAll(sec => sec < limitToRepair);

                    Console.WriteLine($"{sectionsForRepair.Count} sections need repair.");
                }
            }

            Console.WriteLine($"Pirate ship status: {pirateShipStatus.Sum()}");
            Console.WriteLine($"Warship status: {warShipStatus.Sum()}");
        }

        static bool IsIndexValid(int index, List<int> list)
        {
            if (index >= 0 && index < list.Count)
            {
                return true;
            }

            return false;
        }
    }
}
