using System;

namespace P03._Longer_Line
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
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double distance1 = GetDistance(x1, y1, x2, y2);
            double distance2 = GetDistance(x3, y3, x4, y4);


            if (distance1 >= distance2)
            {
                double pointDistance1 = GetDistance(x1, y1, x, y);
                double pointDistance2 = GetDistance(x2, y2, x, y);

                if (pointDistance1 <= pointDistance2)
                {
                    Print(x1, y1, x2, y2);
                }
                else
                {
                    Print(x2, y2, x1, y1);
                }
            }
            else
            {
                double pointDistance1 = GetDistance(x3, y3, x, y);
                double pointDistance2 = GetDistance(x4, y4, x, y);

                if (pointDistance1 <= pointDistance2)
                {
                    Print(x3,y3,x4,y4);
                }
                else
                {
                    Print(x4,y4,x3,y3);
                }
            }
        }
        static double GetDistance(double x, double y, double checkX, double checkY)
        {
            double distance = Math.Sqrt(Math.Pow((checkX - x), 2) + Math.Pow((checkY - y), 2));

            return distance;
        }
        static void Print(double x, double y, double x1, double y1)
        {
            Console.WriteLine($"({x}, {y})({x1}, {y1})");
        }
    }
}
