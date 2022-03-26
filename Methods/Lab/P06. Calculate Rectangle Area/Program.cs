using System;

namespace P06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine(GetRectangleArea(sideA, sideB));
        }
        static double GetRectangleArea(double sideA, double sideB)
        {
            return sideA * sideB;
        }
    }
}
