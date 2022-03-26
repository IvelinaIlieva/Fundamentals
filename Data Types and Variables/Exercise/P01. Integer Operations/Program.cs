using System;

namespace P01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            long sum = (long)firstNumber + secondNumber;
            long divide = sum / thirdNumber;
            long multiply = divide * fourthNumber;

            Console.WriteLine(multiply);
        }
    }
}
