using System;
using System.Text;

namespace P05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder letters = new StringBuilder();
            StringBuilder digits = new StringBuilder();
            StringBuilder others = new StringBuilder();

            foreach (char ch in input.ToCharArray())
            {
                if (char.IsLetter(ch))
                {
                    letters.Append(ch);
                }
                else if (char.IsDigit(ch))
                {
                    digits.Append(ch);
                }
                else
                {
                    others.Append(ch);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
