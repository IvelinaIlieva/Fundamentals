using System;

namespace P02._Ascii_Sumator
{
    internal class Program
    {
        static void Main()
        {
            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());

            string charInput = Console.ReadLine();

            int sum = 0;

            foreach (char ch in charInput)
            {
                if (ch > startChar && ch < endChar)
                {
                    sum += ch;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
