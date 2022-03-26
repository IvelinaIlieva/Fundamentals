using System;

namespace P03._Characters_in_Range
{
    internal class Program
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            PrintCharBetween(firstChar, secondChar);
        }

        static void PrintCharBetween(char char1, char char2)
        {
            char bigger = char1;
            char smaller = char2;

            if (char1 < char2)
            {
                bigger = char2;
                smaller = char1;
            }

            int start = smaller + 1;
            
            for (char i = (char)start; i < bigger; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
