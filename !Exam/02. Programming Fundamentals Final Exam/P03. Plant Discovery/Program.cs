using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Plant_Discovery
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, int> plantRarity = new Dictionary<string, int>();
            Dictionary<string, List<double>> plantRating = new Dictionary<string, List<double>>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                string[] plantInfo = Console.ReadLine().Split("<->");
                string name = plantInfo[0];
                int rarity = int.Parse(plantInfo[1]);

                if (!plantRarity.ContainsKey(name))
                {
                    plantRarity[name] = 0;
                    plantRating[name] = new List<double>();
                }

                plantRarity[name] = rarity;
            }

            string cmd;
            while ((cmd = Console.ReadLine()) != "Exhibition")
            {
                string[] cmdInfo = cmd.Split(": ");

                string cmdType = cmdInfo[0];
                string[] plantInfo = cmdInfo[1].Split(" - ");
                string name = plantInfo[0];

                if (!plantRarity.ContainsKey(name))
                {
                    Console.WriteLine("error");
                    continue;
                }

                if (cmdType == "Rate")
                {
                    double rating = double.Parse(plantInfo[1]);
                    plantRating[name].Add(rating);
                }
                else if (cmdType == "Update")
                {
                    int rarity = int.Parse(plantInfo[1]);
                    plantRarity[name] = rarity;
                }
                else if (cmdType == "Reset")
                {
                    plantRating[name].Clear();
                }
            }

            Console.WriteLine("Plants for the exhibition");

            foreach (var kvp in plantRarity)
            {
                double average = 0;

                if (plantRating[kvp.Key].Count != 0)
                {
                    average = plantRating[kvp.Key].Average();
                }
                Console.WriteLine($"- {kvp.Key}; Rarity: {kvp.Value}; Rating: {average:f2}");
            }
        }
    }
}
