using System;
using System.Linq;

namespace P10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] arrLadybugs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] initialField = new int[fieldSize];

            foreach (int field in arrLadybugs)
            {
                if (field >= 0 && field < fieldSize)
                {
                    initialField[field] = 1;
                }                
            }

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] flight = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                int ladybugField = int.Parse(flight[0]);
                string direction = flight[1];
                int movies = int.Parse(flight[2]);


                if (ladybugField < 0 || ladybugField >= fieldSize)
                {
                    continue;
                }
                if (initialField[ladybugField] == 0)
                {
                    continue;
                }


                if (direction == "left")
                {
                    movies = -movies;
                }

                while (true)
                {
                    initialField[ladybugField] = 0;
                    if (ladybugField + movies < 0 || ladybugField + movies >= fieldSize)
                    {
                        break;
                    }

                    if (initialField[ladybugField + movies] == 0)
                    {
                        initialField[ladybugField + movies] = 1;
                        break;
                    }

                    movies += movies;
                }
            }
            Console.WriteLine(String.Join(" ", initialField));
        }
    }
}