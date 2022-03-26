using System;

namespace P10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int newPower = pokePower;
            int counter = 0;
            double divide = pokePower / 2.0;

            while (newPower >= distance)
            {
                newPower -= distance;
                counter++;

                if (newPower == divide && exhaustionFactor != 0)
                {
                    newPower /= exhaustionFactor;
                }
            }
            Console.WriteLine(newPower);
            Console.WriteLine(counter);
        }
    }
}
