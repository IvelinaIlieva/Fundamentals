using System;
using System.Linq;

namespace P01._Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfStrings = int.Parse(Console.ReadLine());
            char[] vowels = new char[10] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            int[] nameSum = new int[countOfStrings];

            for (int i = 0; i < countOfStrings; i++)
            {
                string input = Console.ReadLine();
                int currSum = 0;
                int sumOfVowels = 0;
                int sumOfConsonants = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    if (vowels.Contains(input[j]))
                    {
                        sumOfVowels += input[j] * input.Length;
                    }
                    else
                    {
                        sumOfConsonants += input[j] / input.Length;
                    }
                    currSum = sumOfVowels + sumOfConsonants;
                }
                nameSum[i] = currSum;
            }
            Array.Sort(nameSum);
            foreach (int c in nameSum)
            {
                Console.WriteLine(c);
            }
        }
    }
}
