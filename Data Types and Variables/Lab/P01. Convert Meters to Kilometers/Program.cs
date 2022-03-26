using System;

namespace P01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            decimal kilometers = (decimal) meters / 1000;
            
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
