using System;

namespace P02._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfRows = int.Parse(Console.ReadLine());

            int[] currArray = new int[1] { 1 };

            for (int rows = 1; rows < countOfRows; rows++)
            {
                int[] newArray = new int[currArray.Length + 1];

                for (int col = 0; col < currArray.Length; col++)
                {
                    newArray[col] += currArray[col];
                    newArray[col + 1] += currArray[col];
                }
                Console.WriteLine(String.Join(" ", currArray));
                currArray = newArray;
            }
            Console.WriteLine(String.Join(" ", currArray));
        }
    }
}

