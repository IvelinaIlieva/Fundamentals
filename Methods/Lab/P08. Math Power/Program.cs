using System;

namespace P08._Math_Power
{
    internal class Program
    {
        static void Main()
        {
            double @base = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(GetThePowerOfBase(@base,power));
        }
        static double GetThePowerOfBase(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}
