using System;

namespace P02._From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfLines; i++)
            {
                string line = Console.ReadLine();
                string word1 = line.Split(' ')[0];
                string word2 = line.Split(' ')[1];
                long num1 = long.Parse(word1);
                long num2 = long.Parse(word2);
                long sumOfDigit = 0;

                if (num1 >= num2)
                {
                    while (num1 != 0)
                    {
                        long curDigit = num1 % 10;
                        sumOfDigit += curDigit;
                        num1 /= 10;
                    }
                }
                else if (num1 < num2)
                {
                    while (num2 != 0)
                    {
                        long curDigit = num2 % 10;
                        sumOfDigit += curDigit;
                        num2 /= 10;
                    }
                }
                Console.WriteLine(Math.Abs(sumOfDigit));
            }
        }
    }
}
