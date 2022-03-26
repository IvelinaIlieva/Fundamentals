using System;
using System.Text;

namespace P06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder output = new StringBuilder();

            output.Append(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    output.Append(input[i]);
                }
            }

            Console.WriteLine(output);
        }
    }
}
