using System;
using System.Linq;


namespace P01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMin(num1, num2, num3));
        }

        static int GetMin(int n1, int n2, int n3)
        {
            int min = int.MaxValue;
            int[] newArray = new int[] { n1, n2, n3 };
            min = newArray.Min();
            return min;
        }
    }
}
