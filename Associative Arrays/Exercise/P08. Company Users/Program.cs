using System;
using System.Collections.Generic;

namespace P08._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> employeeSheet = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] employee = command.Split("->");
                string company = employee[0];
                string employeeID = employee[1];

                if (!employeeSheet.ContainsKey(company))
                {
                    employeeSheet[company] = new List<string>();
                }
                
                if (!employeeSheet[company].Contains(employeeID))
                {
                    employeeSheet[company].Add(employeeID);
                }
            }

            foreach (var employee in employeeSheet)
            {
                Console.WriteLine(employee.Key);

                foreach (string ID in employee.Value)
                {
                    Console.WriteLine($"--{ID}");
                }
            }
        }
    }
}
