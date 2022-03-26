using System;

namespace P04._Refactoring_Prime_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int currNumber = 2; currNumber <= endNumber; currNumber++)
            {
                bool isPrime = true;

                for (int divider = 2; divider < currNumber; divider++)
                {
                    if (currNumber % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currNumber} -> {isPrime.ToString().ToLower()}");
            }
        }
    }
}