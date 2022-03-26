using System;

namespace P03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int counter = 0;

            while (countOfPeople != 0)
            {
                if (capacity >= countOfPeople)
                {
                    counter++;
                    break;
                }
                countOfPeople -= capacity;
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
