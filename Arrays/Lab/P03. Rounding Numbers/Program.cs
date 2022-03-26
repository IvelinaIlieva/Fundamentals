using System;
using System.Linq;

namespace P03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(Math.Abs(array[i]) != 0 ? $"{array[i]} => {(int)Math.Round(array[i], MidpointRounding.AwayFromZero)}" : "0 => 0");
            }
        }
    }
}
