using System;

namespace P01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string username in usernames)
            {
                if (IsLenghtOK(username) && IsContainOK(username))
                {
                    Console.WriteLine(username);
                }
            }

        }
        static bool IsLenghtOK(string word)
        {
            const int MinLetters = 3;
            const int MaxLetters = 16;

            if (word.Length > MinLetters && word.Length < MaxLetters)
            {
                return true;
            }

            return false;
        }

        static bool IsContainOK(string word)
        {
            foreach (char c in word)
            {
                if (!char.IsLetterOrDigit(c) && c != '-' && c != '_')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
