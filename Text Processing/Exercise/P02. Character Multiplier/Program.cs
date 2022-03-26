using System;

namespace P02._Character_Multiplier
{
    internal class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');

            string word1 = words[0];
            string word2 = words[1];

            int totalSum = 0;

            int minLenght = Math.Min(word1.Length, word2.Length);

            totalSum = EqualsLenght(word1, word2, totalSum, minLenght);

            if (word1.Length != word2.Length)
            {
                string leftChars = minLenght == word1.Length
                                ? word2.Substring(minLenght)
                                : word1.Substring(minLenght);

                totalSum += LeftCharsSum(leftChars);
            }

            Console.WriteLine(totalSum);
        }

        static int EqualsLenght(string word1, string word2, int totalSum, int minLenght)
        {
            for (int i = 0; i < minLenght; i++)
            {
                totalSum += word1[i] * word2[i];
            }

            return totalSum;
        }
        static int LeftCharsSum(string word)
        {
            int sum = 0;

            foreach (char c in word)
            {
                sum += c;
            }

            return sum;
        }
    }
}
