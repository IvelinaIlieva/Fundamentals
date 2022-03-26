using System;

namespace P04._Text_Filter
{
    internal class Program
    {
        static void Main()
        {
            string[] wordsToReplace = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (string word in wordsToReplace)
            {
                string replacement = new string('*', word.Length);

                while (text.Contains(word))
                {
                    text = text.Replace(word, replacement);
                }
            }

            Console.WriteLine(text);
        }
    }
}
