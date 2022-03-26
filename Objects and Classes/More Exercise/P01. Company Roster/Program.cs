using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Company_Roster
{
    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Salary:f2}";
        }
    }

    internal class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();
            List<string> departments = new List<string>();

            int countOfEmployees = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countOfEmployees; i++)
            {
                string[] employeeArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = employeeArgs[0];
                double salary = double.Parse(employeeArgs[1]);
                string department = employeeArgs[2];

                Employee newEmployee = new Employee(name, salary, department);
                employees.Add(newEmployee);

                if (!departments.Contains(department))
                {
                    departments.Add(department);
                }
            }

            double maxAverage = 0;
            string bestDep = string.Empty;

            foreach (string dep in departments)
            {
                List<Employee> orderedList = employees.FindAll(e => e.Department == dep);
                double currAvSalary = AverageSum(orderedList);

                if (currAvSalary > maxAverage)
                {
                    maxAverage = currAvSalary;
                    bestDep = dep;
                }
            }

            List<Employee> bestEmployeesBySalary = employees
                .FindAll(e => e.Department == bestDep)
                .OrderByDescending(e => e.Salary)
                .ToList();

            Console.WriteLine($"Highest Average Salary: {bestDep}");

            foreach (Employee employee in bestEmployeesBySalary)
            {
                Console.WriteLine(employee);
            }
        }

        static double AverageSum(List<Employee> list)
        {
            double totalSalary = 0;

            foreach (Employee employee in list)
            {
                totalSalary += employee.Salary;
            }

            return totalSalary/list.Count;
        }
    }
}
