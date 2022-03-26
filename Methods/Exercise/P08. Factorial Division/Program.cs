using System;
using System.Diagnostics.CodeAnalysis;

namespace P08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            double factNum1 = GetFactorial(number1);
            double factNum2 = GetFactorial(number2);
            
            Console.WriteLine($"{factNum1/factNum2:f2}");
        }
        
        static double GetFactorial(int num)
        {
            double factorial = num;

            for (int i = num - 1; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
