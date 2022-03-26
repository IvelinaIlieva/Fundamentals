using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._Snowwhite
{
    internal class Program
    {
        static void Main()
        {
            //key = name + colorHat; value = physics
            Dictionary<string, int> dwarfSheet = new Dictionary<string, int>();

            string command;
            while ((command = Console.ReadLine()) != "Once upon a time")
            {
                string[] dwarfArgs = command.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);
                string name = dwarfArgs[0];
                string colorHat = dwarfArgs[1];
                int physics = int.Parse(dwarfArgs[2]);

                string dwarfNameAndColor = $"{name} : {colorHat}";

                //If 2 dwarfs have the same name but different colors, they should be considered different dwarfs, and you should store both of them.
                if (!dwarfSheet.ContainsKey(dwarfNameAndColor))
                {
                    dwarfSheet[dwarfNameAndColor] = physics;
                }
                //If 2 dwarfs have the same name and the same color, store the one with the higher physics
                else
                {
                    if (dwarfSheet[dwarfNameAndColor] < physics)
                    {
                        dwarfSheet[dwarfNameAndColor] = physics;
                    }
                }
            }

            //You must order the dwarfs by physics in descending order and then by the total count of dwarfs with the same hat color in descending order. 

            foreach (var kvp in dwarfSheet
                         .OrderByDescending(x => x.Value)
                         .ThenByDescending(x 
                             => dwarfSheet.Count(h 
                                 => h.Key.Split(" : ")[1] == x.Key.Split(" : ")[1]))) 
            {
                string name = kvp.Key.Split(" : ")[0];
                string colorHat = kvp.Key.Split(" : ")[1];

                Console.WriteLine($"({colorHat}) {name} <-> {kvp.Value}");
            }
        }
    }
}
