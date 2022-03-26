using System;
using System.Text;

namespace P05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int multiplyer = int.Parse(Console.ReadLine());

            if (multiplyer == 0)
            {
                Console.WriteLine("0");
                return;
            }

            StringBuilder result = new StringBuilder();
            int left = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int currDigit = input[i] - '0';
                int currMultiply = currDigit * multiplyer + left;

                result.Insert(0, currMultiply % 10);

                left = currMultiply / 10;
            }

            if (left != 0)
            {
                result.Insert(0, left);
            }

            Console.WriteLine(result);
        }
    }
}
