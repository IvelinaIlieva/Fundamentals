using System;
using System.Collections.Generic;

namespace P04._Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
    internal class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] args = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstName = args[0];
                string lastName = args[1];
                int age = int.Parse(args[2]);
                string homeTown = args[3];

                Student student = new Student()
                    {FirstName = firstName, LastName = lastName, Age = age, HomeTown = homeTown};

                students.Add(student);
            }

            string town = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == town)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
