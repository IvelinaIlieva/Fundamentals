using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace P03._Deck_of_Cards
{
    internal class Program
    {
        static void Main()
        {
            List<string> startDeck = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int countOfCommands = int.Parse(Console.ReadLine());

            for (int i = 1; i <= countOfCommands; i++)
            {
                string[] commArgs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string commType = commArgs[0];

                if (commType == "Add")
                {
                    string cardToAdd = commArgs[1];

                    if (startDeck.Contains(cardToAdd))
                    {
                        Console.WriteLine("Card is already in the deck");
                    }
                    else
                    {
                        startDeck.Add(cardToAdd);
                        Console.WriteLine("Card successfully added");
                    }
                }
                else if (commType == "Remove")
                {
                    string cardToRemove = commArgs[1];

                    if (startDeck.Contains(cardToRemove))
                    {
                        startDeck.Remove(cardToRemove);
                        Console.WriteLine("Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }
                else if (commType == "Remove At")
                {
                    int indexToRemove = int.Parse(commArgs[1]);

                    if (IsIndexValid(indexToRemove, startDeck))
                    {
                        startDeck.RemoveAt(indexToRemove);
                        Console.WriteLine("Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                else if (commType == "Insert")
                {
                    int indexToInsert = int.Parse(commArgs[1]);
                    string cardToInsert = commArgs[2];

                    if (!IsIndexValid(indexToInsert, startDeck))
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else
                    {
                        if (startDeck.Contains(cardToInsert))
                        {
                            Console.WriteLine("Card is already added");
                        }
                        else
                        {
                            startDeck.Insert(indexToInsert,cardToInsert);
                            Console.WriteLine("Card successfully added");
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(", ", startDeck));
        }

        static bool IsIndexValid(int index, List<string> input)
        {
            return index >= 0 && index < input.Count;
        }
    }
}
