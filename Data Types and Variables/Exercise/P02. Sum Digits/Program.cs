using System;

namespace P02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sumOfDigit = 0;

            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;
                sumOfDigit += digit;
            }
            Console.WriteLine(sumOfDigit);  
        }
    }
}
