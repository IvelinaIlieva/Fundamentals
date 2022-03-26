using System;

namespace P08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte countOfKegs = byte.Parse(Console.ReadLine());
            double maxVolume = 0;
            string maxCan = string.Empty;

            for (int i = 0; i < countOfKegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume>maxVolume)
                {
                    maxVolume = volume;
                    maxCan = model;
                }
            }
            Console.WriteLine(maxCan);
        }
    }
}
