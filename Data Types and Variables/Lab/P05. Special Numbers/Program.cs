using System;

namespace P05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
                      
            for (int i = 1; i <= number; i++)
            {
                int sumOfDigit = 0;
                int newNumber = i;

                while (newNumber != 0)
                {
                    int digit = newNumber % 10;                    
                    sumOfDigit += digit;
                    newNumber /= 10;
                }
                bool isDivisible = sumOfDigit == 5 || sumOfDigit == 7 || sumOfDigit == 11;
                Console.WriteLine($"{i} -> {isDivisible}");
            }
        }
    }
}
