using System;
using System.Collections.Generic;

namespace P03._P_rates
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, int> population = new Dictionary<string, int>();
            Dictionary<string, int> gold = new Dictionary<string, int>();

            string firstCommand;
            while ((firstCommand = Console.ReadLine()) != "Sail")
            {
                string[] cityInfo = firstCommand.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string cityName = cityInfo[0];
                int cityPopulation = int.Parse(cityInfo[1]);
                int cityGold = int.Parse(cityInfo[2]);

                if (!population.ContainsKey(cityName))
                {
                    population[cityName] = 0;
                    gold[cityName] = 0;
                }

                population[cityName] += cityPopulation;
                gold[cityName] += cityGold;
            }

            string secondCommand;
            while ((secondCommand = Console.ReadLine()) != "End")
            {
                string[] eventInfo = secondCommand.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string eventName = eventInfo[0];
                string cityName = eventInfo[1];

                if (eventName == "Plunder")
                {
                    int countOfPeople = int.Parse(eventInfo[2]);
                    int countOfGold = int.Parse(eventInfo[3]);

                    Console.WriteLine($"{cityName} plundered! {countOfGold} gold stolen, {countOfPeople} citizens killed.");

                    population[cityName] -= countOfPeople;
                    gold[cityName] -= countOfGold;

                    if (population[cityName] <= 0 || gold[cityName] <= 0)
                    {
                        Console.WriteLine($"{cityName} has been wiped off the map!");

                        population.Remove(cityName);
                        gold.Remove(cityName);
                    }
                }
                else if (eventName == "Prosper")
                {
                    int countOfGold = int.Parse(eventInfo[2]);

                    if (countOfGold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }

                    gold[cityName] += countOfGold;
                    Console.WriteLine($"{countOfGold} gold added to the city treasury. {cityName} now has {gold[cityName]} gold.");
                }
            }

            if (population.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
                return;
            }

            Console.WriteLine($"Ahoy, Captain! There are {population.Count} wealthy settlements to go to:");

            foreach (var kvp in population)
            {
                string city = kvp.Key;
                int populationOfCity = kvp.Value;
                int goldOfCity = gold[city];

                Console.WriteLine($"{city} -> Population: {populationOfCity} citizens, Gold: {goldOfCity} kg");
            }
        }
    }
}
