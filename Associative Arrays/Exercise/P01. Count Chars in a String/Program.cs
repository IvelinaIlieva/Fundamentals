using System;
using System.Collections.Generic;

namespace P01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
                
            Dictionary<char, int> inputDictionary = new Dictionary<char, int>();

            foreach (char symbol in input)
            {
                if (symbol == ' ')
                {
                    continue;
                }

                if (!inputDictionary.ContainsKey(symbol))
                {
                    inputDictionary[symbol] = 0;
                }

                inputDictionary[symbol]++;
            }

            foreach (var kvp in inputDictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
