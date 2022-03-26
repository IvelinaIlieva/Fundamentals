using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P01.Messaging
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<char> symbols = Console.ReadLine().ToList();

            int[] numForPass = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];
                int sum = 0;

                while (currNum != 0)
                {
                    sum += currNum % 10;
                    currNum /= 10;
                }

                numForPass[i] = sum;
            }

            StringBuilder pass = new StringBuilder();

            int count = 0;
            while (pass.Length != numForPass.Length)
            {
                int index = numForPass[count] % symbols.Count;
                pass.Append(symbols[index]);
                symbols.RemoveAt(index);
                count++;
            }

            Console.WriteLine(pass.ToString());
        }
    }
}
