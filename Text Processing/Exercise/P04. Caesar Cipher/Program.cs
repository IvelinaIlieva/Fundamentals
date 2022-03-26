using System;
using System.Text;

namespace P04._Caesar_Cipher
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                output.Append((char)(input[i] + 3));
            }

            Console.WriteLine(output);
        }
    }
}
