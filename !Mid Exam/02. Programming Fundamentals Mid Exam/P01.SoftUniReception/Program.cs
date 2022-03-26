using System;

namespace P01.SoftUniReception
{
    internal class Program
    {
        static void Main()
        {
            int firstEmployeeEfficient = int.Parse(Console.ReadLine());
            int secondEmployeeEfficient = int.Parse(Console.ReadLine());
            int thirdEmployeeEfficient = int.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());

            int answerPerHour = firstEmployeeEfficient + secondEmployeeEfficient + thirdEmployeeEfficient;
            int hours = 0;

            while (studentCount > 0)
            {
                hours++;
                studentCount -= answerPerHour;

                if (hours % 4 == 0)
                {
                    hours++;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
