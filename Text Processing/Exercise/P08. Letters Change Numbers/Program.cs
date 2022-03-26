using System;

namespace P08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            decimal totalSum = 0;

            foreach (string item in input)
            {
                char firstLetter = item[0];
                char lastLetter = item[item.Length - 1];
                decimal number = decimal.Parse(new string(item).Substring(1, item.Length - 2));

                totalSum += ResultOfLastLetter(lastLetter, ResultOfFirstLetter(firstLetter, number));
            }

            Console.WriteLine($"{totalSum:f2}");
        }
        static decimal ResultOfFirstLetter(char firstLetter, decimal number)
        {
            if (char.IsUpper(firstLetter))
            {
                int divider = firstLetter - 'A' + 1;

                return number / divider;
            }
            else
            {
                int multiplyer = firstLetter - 'a' + 1;

                return number * multiplyer;
            }        
        }

        static decimal ResultOfLastLetter(char lastLetter, decimal number)
        {
            if (char.IsUpper(lastLetter))
            {
                int subtrahend = lastLetter - 'A' + 1;

                return number - subtrahend;
            }
            else
            {
                int addend = lastLetter - 'a' + 1;

                return number + addend;
            }
        }
    }
}
