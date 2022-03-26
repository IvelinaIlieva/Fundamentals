using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._Cards_Game
{
    internal class Program
    {
        static void Main()
        {
            List<int> deck1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> deck2 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                int winCard = 0;
                int lostCard = 0;

                if (deck1[0] > deck2[0])
                {
                    winCard = deck1[0];
                    lostCard = deck2[0];
                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                    deck1.Add(winCard);
                    deck1.Add(lostCard);
                }
                else if (deck1[0] < deck2[0])
                {
                    winCard = deck2[0];
                    lostCard = deck1[0];
                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                    deck2.Add(winCard);
                    deck2.Add(lostCard);
                }
                else
                {
                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                }

                if (deck1.Count == 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {deck2.Sum()}");
                    break;
                }
                else if (deck2.Count == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {deck1.Sum()}");
                    break;
                }
            }
        }
    }
}
