using System;

namespace P06._Middle_Characters
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(GetTheMiddleChar(input));
        }

        static string GetTheMiddleChar(string words)
        {
            int dev = words.Length / 2;

            if (words.Length % 2 != 0)
            {
                return words[dev].ToString();
            }
            else
            {
                return words[dev - 1].ToString() + words[dev].ToString();
            }
        }
    }
}
