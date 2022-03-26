using System;

namespace P02._Center_Point
{
    internal class Program
    {
        static void Main()
        {
            const double x = 0;
            const double y = 0;
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double distance1 = GetDistance(x1, y1, x, y);
            double distance2 = GetDistance(x2, y2, x, y);

            if (distance1 < distance2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        static double GetDistance(double x, double y, double checkX, int checkY)
        {
            double distance = Math.Sqrt(Math.Pow((checkX - x), 2) + Math.Pow((checkY - y), 2));

            return distance;
        }
    }
}
