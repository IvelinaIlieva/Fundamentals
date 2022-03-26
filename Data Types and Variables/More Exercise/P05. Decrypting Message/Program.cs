using System;

namespace P05._Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int keyNumber = int.Parse(Console.ReadLine());
            int countOfLines = int.Parse(Console.ReadLine());

            string word = "";
            for (int i = 0; i < countOfLines; i++)
            {
                char curChar = char.Parse(Console.ReadLine());
                int newChar = (int)curChar + keyNumber;

                word += (char)newChar;
            }
            Console.WriteLine(word);
        }
    }
}
