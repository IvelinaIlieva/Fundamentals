using System;

namespace P11._Math_operations
{
    internal class Program
    {
        static void Main()
        {
            double num1 = double.Parse(Console.ReadLine());
            string opp = Console.ReadLine();
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine(GetResult(num1, opp, num2));
        }
        static double GetResult(double num1, string opp, double num2)
        {
            double result = 0;
            switch (opp)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }
            return result;
        }
    }
}
