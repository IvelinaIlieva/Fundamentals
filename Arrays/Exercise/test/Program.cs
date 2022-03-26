using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] ladybugs = new int[int.Parse(Console.ReadLine())];
        int[] indexesOfLadyBugs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        for (int i = 0; i < indexesOfLadyBugs.Length; i++)
        {
            if (indexesOfLadyBugs[i] >= 0 && indexesOfLadyBugs[i] < ladybugs.Length) //!!!
            {
                ladybugs[indexesOfLadyBugs[i]] = 1;
            }
        }
        string command = Console.ReadLine();
        while (command != "end")
        {
            string[] threeWordsCommand = command.Split().ToArray();
            int indexOfLadyBug = int.Parse(threeWordsCommand[0]);
            int positionsMoved = int.Parse(threeWordsCommand[2]);
            if (indexOfLadyBug >= 0 && indexOfLadyBug < ladybugs.Length && ladybugs[indexOfLadyBug] == 1)
            {
                ladybugs[indexOfLadyBug] = 0;

                if (threeWordsCommand[1] == "left")
                {
                    positionsMoved = -positionsMoved;
                }

                while (true)
                {
                    if (indexOfLadyBug + positionsMoved >= ladybugs.Length || indexOfLadyBug + positionsMoved < 0)
                    {
                        break;
                    }

                    if (ladybugs[indexOfLadyBug + positionsMoved] == 0)
                    {
                        ladybugs[indexOfLadyBug + positionsMoved] = 1;
                        break;
                    }

                    positionsMoved += positionsMoved;
                }

            }
            command = Console.ReadLine();
        }
        Console.WriteLine(String.Join(' ', ladybugs));
    }
}
