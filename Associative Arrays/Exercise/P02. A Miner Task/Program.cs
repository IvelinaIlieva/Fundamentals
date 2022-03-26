using System;
using System.Collections.Generic;

namespace P02._A_Miner_Task
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            string command;
            while ((command=Console.ReadLine()) != "stop")
            {
                string resource = command;
                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }

                resources[resource] += quantity;
            }

            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
