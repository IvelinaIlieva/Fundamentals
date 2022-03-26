using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._Student_Academy
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, List<double>> studentsDiary = new Dictionary<string, List<double>>();

            int countOfRows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countOfRows; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsDiary.ContainsKey(name))
                {
                    studentsDiary[name] = new List<double>();
                }

                studentsDiary[name].Add(grade);
            }

            foreach (var student in studentsDiary)
            {
                double averageGrade = student.Value.Average();

                if (averageGrade >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {averageGrade:f2}");
                }
            }
        }
    }
}
