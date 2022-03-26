using System;

namespace P01._Bonus_Scoring_System
{
    internal class Program
    {
        static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numberOfLectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            decimal maxBonus = decimal.MinValue;
            int attendanceOfBestStudent = 0;

            for (int i = 1; i <= numberOfStudents; i++)
            {
                int attendance = int.Parse(Console.ReadLine());

                decimal totalBonus = Math.Ceiling((decimal)attendance / numberOfLectures * (5 + additionalBonus));

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    attendanceOfBestStudent = attendance;
                }
                
            }

            if (numberOfStudents == 0 || numberOfLectures == 0)
            {
                maxBonus = 0;
                attendanceOfBestStudent = 0;
            }

            Console.WriteLine($"Max Bonus: {maxBonus:f0}.");
            Console.WriteLine($"The student has attended {attendanceOfBestStudent} lectures.");
        }
    }
}
