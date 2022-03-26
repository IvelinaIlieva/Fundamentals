using System;
using System.Numerics;

namespace P11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfSnowballs = int.Parse(Console.ReadLine());

            BigInteger maxVolume = 0;
            int maxsnowballSnow = 0;
            int maxSnowballTime = 0;
            int maxSnowballQuality = 0;

            for (int i = 0; i < countOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger volume = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (maxVolume < volume)
                {
                    maxVolume = volume;
                    maxSnowballQuality = snowballQuality;
                    maxsnowballSnow = snowballSnow;
                    maxSnowballTime = snowballTime;
                }
            }
            Console.WriteLine($"{maxsnowballSnow} : {maxSnowballTime} = {maxVolume} ({maxSnowballQuality})");
        }
    }
}
