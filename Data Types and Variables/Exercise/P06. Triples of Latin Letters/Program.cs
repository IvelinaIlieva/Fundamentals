using System;

namespace P06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfLetters = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < (char)countOfLetters + 'a'; i++)
            {
                for (char j = 'a'; j < (char)countOfLetters + 'a'; j++)
                {
                    for (char k = 'a'; k < (char)countOfLetters + 'a'; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
