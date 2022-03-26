using System;

namespace P01._Randomize_Words
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Random invert = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int randomIndex = invert.Next(0 , input.Length);

                (input[i], input[randomIndex]) = (input[randomIndex], input[i]);
            }

            foreach (string word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
