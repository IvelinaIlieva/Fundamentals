using System;
using System.Text;

namespace P02._Repeat_Strings
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            StringBuilder output = new StringBuilder();

            foreach (string word in input)
            {
                for (int i = 1; i <= word.Length; i++)
                {
                    output.Append(word);
                }
            }

            Console.WriteLine(output.ToString());
        }
    }
}
