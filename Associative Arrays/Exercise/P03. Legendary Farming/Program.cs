using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace P03._Legendary_Farming
{
    internal class Program
    {
        static void Main()
        {
            const int NeededMaterial = 250;

            Dictionary<string, int> keyMaterialDictionary = new Dictionary<string, int>()
            {
                {"shards", 0},
                {"motes", 0},
                {"fragments", 0}
            };

            Dictionary<string, int> junkDictionary = new Dictionary<string, int>();

            Dictionary<string, string> materialsAndItem = new Dictionary<string, string>()
            {
                {"shards", "Shadowmourne"},
                {"motes", "Dragonwrath"},
                {"fragments", "Valanyr"}
            };

            bool isFind = false;

            while (!isFind)
            {
                string[] input = Console.ReadLine()
                    .ToLower()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantityOfMaterial = int.Parse(input[i]);
                    string material = input[i + 1];

                    if (materialsAndItem.ContainsKey(material))
                    {
                        keyMaterialDictionary[material] += quantityOfMaterial;

                        if (keyMaterialDictionary[material] >= NeededMaterial)
                        {
                            Console.WriteLine($"{materialsAndItem[material]} obtained!");
                            keyMaterialDictionary[material] -= NeededMaterial;
                            isFind = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkDictionary.ContainsKey(material))
                        {
                            junkDictionary[material] = 0;
                        }

                        junkDictionary[material] += quantityOfMaterial;
                    }
                }
            }

            Print(keyMaterialDictionary);

            Print(junkDictionary);
        }

        static void Print(Dictionary<string, int> dictionary)
        {
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
