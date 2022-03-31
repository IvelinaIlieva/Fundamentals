using System;
using System.Collections.Generic;

namespace P03._Need_for_Speed_III
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, int> carFuel = new Dictionary<string, int>();
            Dictionary<string, int> carMileage = new Dictionary<string, int>();

            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                string[] carInfo = Console.ReadLine().Split('|');

                string name = carInfo[0];
                int mileage = int.Parse(carInfo[1]);
                int fuel = int.Parse(carInfo[2]);

                carFuel[name] = fuel;
                carMileage[name] = mileage;
            }

            string cmd;
            while ((cmd = Console.ReadLine()) != "Stop")
            {
                string[] cmdArgs = cmd.Split(" : ");

                string cmdType = cmdArgs[0];
                string name = cmdArgs[1];

                if (cmdType == "Drive")
                {
                    int distance = int.Parse(cmdArgs[2]);
                    int fuel = int.Parse(cmdArgs[3]);

                    Drive(name, distance, fuel, carFuel, carMileage);
                }
                else if (cmdType == "Refuel")
                {
                    int fuel = int.Parse(cmdArgs[2]);

                    Refuel(name, fuel, carFuel);
                }
                else if (cmdType == "Revert")
                {
                    int km = int.Parse(cmdArgs[2]);
                    carMileage[name] -= km;

                    if (carMileage[name] < 10000)
                    {
                        carMileage[name] = 10000;
                        continue;
                    }

                    Console.WriteLine($"{name} mileage decreased by {km} kilometers");
                }
            }

            foreach (var kvp in carFuel)
            {
                Console.WriteLine($"{kvp.Key} -> Mileage: {carMileage[kvp.Key]} kms, Fuel in the tank: {kvp.Value} lt.");
            }
        }

        static void Drive(string name, int distance, int fuel, Dictionary<string, int> fuelDict,
            Dictionary<string, int> milDict)
        {
            if (fuelDict[name] >= fuel)
            {
                milDict[name] += distance;
                fuelDict[name] -= fuel;
                Console.WriteLine($"{name} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                if (milDict[name] >= 100000)
                {
                    milDict.Remove(name);
                    fuelDict.Remove(name);
                    Console.WriteLine($"Time to sell the {name}!");
                }
            }
            else
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
        }

        static void Refuel(string name, int fuel, Dictionary<string, int> fuelDict)
        {
            int refillFuel = 0;

            if (fuelDict[name] + fuel <= 75)
            {
                refillFuel = fuel;
                fuelDict[name] += fuel;
            }
            else
            {
                refillFuel = 75 - fuelDict[name];
                fuelDict[name] = 75;
            }

            Console.WriteLine($"{name} refueled with {refillFuel} liters");
        }
    }
}
