using System;
using System.Text;

namespace P07._String_Explosion
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder output = new StringBuilder();
            int bombPower = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currSymbol = input[i];

                if (currSymbol != '>')
                {
                    if (bombPower == 0)
                    {
                        output.Append(currSymbol);
                    }
                    else
                    {
                        bombPower--;
                    }
                }
                else
                {
                    output.Append(currSymbol);
                    bombPower += input[i + 1] - '0';
                }
            }

            Console.Write(output);
        }
    }
}
