using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._Students
{
    internal class Program
    {
        class Student
        {
            public Student(string firstName, string lastName, double grade)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Grade = grade;
            }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public override string ToString()
            {
                return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
            }
        }
        static void Main()
        {
            List<Student> students = new List<Student>();

            int countOfStudents = int.Parse(Console.ReadLine());

            for (int i = 1; i <= countOfStudents; i++)
            {
                string[] studentParameters = Console.ReadLine().Split();

                string firstName = studentParameters[0];
                string lastName = studentParameters[1];
                double grade = double.Parse(studentParameters[2]);

                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }

            students = students.OrderByDescending(s => s.Grade).ToList();

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
