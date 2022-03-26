using System;

namespace P03._Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            bool isEqual = false;
            double diff = Math.Abs(firstNum - secondNum);

            if (diff < 0.000001)
            {
                isEqual = true;
            }
            Console.WriteLine(isEqual);
        }
    }
}
