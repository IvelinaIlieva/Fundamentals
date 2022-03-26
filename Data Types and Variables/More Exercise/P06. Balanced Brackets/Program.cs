using System;

namespace P06._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());

            int countOpened = 0;
            int countClosed = 0;

            for (int i = 1; i <= countOfLines; i++)
            {
                string input = Console.ReadLine();

                if (input == "()")
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }

                if (input == "(")
                {
                    countOpened++;
                }
                else if (input == ")")
                {
                    countClosed++;
                    if (countOpened - countClosed != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
            }

            if (countClosed != countOpened)
            {
                Console.WriteLine("UNBALANCED");
            }
            else
            {
                Console.WriteLine("BALANCED");
            }
        }
    }
}
