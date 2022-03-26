using System;
using System.Linq;

namespace P04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int countOfRotations = int.Parse(Console.ReadLine());

            int realRotations = countOfRotations % inputArray.Length;
            int[] newArray = inputArray;

            for (int i = 1; i <= realRotations; i++)
            {
                int currNumberToRotate = inputArray[0];
                for (int j = 0; j < inputArray.Length - 1; j++)
                {
                    newArray[j] = inputArray[j + 1];
                }
                newArray[newArray.Length - 1] = currNumberToRotate;
                inputArray = newArray;
            }
            Console.WriteLine(String.Join(" ", newArray));
        }
    }
}
