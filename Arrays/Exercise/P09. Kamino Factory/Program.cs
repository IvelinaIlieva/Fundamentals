using System;
using System.Linq;

namespace P09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            int bestSum = 0;
            int bestIndex = lenght;
            int bestCount = 0;
            int bestDNA = 0;
            int currDNA = 0;
            int[] bestSequence = new int[lenght];

            string command;
            while ((command = Console.ReadLine()) != "Clone them!")
            {
                string inputSequence = command;
                int[] currSequence = command.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                currDNA++;

                int currBestIndex = 0;
                int currBestCountOfOnes = 0;
                int currSum = 0;
                int currIndex = 0;
                int countOfOnes = 0;

                for (int i = 0; i < currSequence.Length; i++)
                {

                    if (currSequence[i] == 1)
                    {
                        countOfOnes++;
                        if (currBestCountOfOnes <= countOfOnes)
                        {
                            currBestCountOfOnes = countOfOnes;
                            currIndex = i;
                        }
                    }
                    else
                    {
                        countOfOnes = 0;
                    }
                }
                bool isBetter = false;
                currBestIndex = currIndex - currBestCountOfOnes;
                currSum = currSequence.Sum();

                if (currBestCountOfOnes > bestCount)
                {
                    isBetter = true;
                }
                else if (currBestCountOfOnes == bestCount)
                {
                    if (bestIndex > currBestIndex)
                    {
                        isBetter = true;                        
                    }
                    else if (bestIndex == currBestIndex)
                    {
                        if (currSum > bestSum)
                        {
                            isBetter = true;
                        }                       
                    }
                }
                if (isBetter)
                {
                    bestCount = currBestCountOfOnes;                    
                    bestSequence = currSequence;
                    bestIndex = currBestIndex;
                    bestSum = currSum;
                    bestDNA = currDNA;
                }
            }                        
                Console.WriteLine($"Best DNA sample {bestDNA} with sum: {bestSum}.");
                Console.WriteLine(String.Join(" ", bestSequence));                      
        }
    }
}
