using System;
using System.Collections.Generic;

namespace P06._Courses
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> courseInfo = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] courseArgs = command.Split(" : ");
                string courseName = courseArgs[0];
                string studentName = courseArgs[1];

                if (!courseInfo.ContainsKey(courseName))
                {
                    courseInfo[courseName] = new List<string>();
                }

                courseInfo[courseName].Add(studentName);
            }

            foreach (var course in courseInfo)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (string student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
