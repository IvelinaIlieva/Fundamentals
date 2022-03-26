using System;

namespace P01.GuineaPig
{
    internal class Program
    {
        static void Main()
        {
            const double FoodPerDay = 300;
            const int DayInAMonth = 30;

            double food = double.Parse(Console.ReadLine()) * 1000;
            double hay = double.Parse(Console.ReadLine()) * 1000;
            double cover = double.Parse(Console.ReadLine()) * 1000;
            double pigWeight = double.Parse(Console.ReadLine()) * 1000;

            bool isEnough = true;

            for (int i = 1; i <= DayInAMonth; i++)
            {
                food -= FoodPerDay;

                if (food <= 0)
                {
                    isEnough = false;
                    break;
                }

                if (i % 2 == 0)
                {
                    hay -= food * 0.05;

                    if (hay <= 0)
                    {
                        isEnough = false;
                        break;
                    }
                }

                if (i % 3 == 0)
                {
                    cover -= pigWeight / 3;

                    if (cover <= 0)
                    {
                        isEnough = false;
                        break;
                    }
                }
            }

            Console.WriteLine(isEnough
                ? $"Everything is fine! Puppy is happy! Food: {food/1000:f2}, Hay: {hay/1000:f2}, Cover: {cover/1000:f2}."
                : "Merry must go to the pet store!");
        }
    }
}
