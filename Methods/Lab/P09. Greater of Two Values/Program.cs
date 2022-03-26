using System;

namespace P09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(number1, number2));
            }
            else if (type == "char")
            {
                char one = char.Parse(Console.ReadLine());
                char two = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(one, two));
            }
            else if (type == "string")
            {
                string word1 = Console.ReadLine();
                string word2 = Console.ReadLine();
                Console.WriteLine(GetMax(word1, word2));
            }

        }
        static int GetMax(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }
        static char GetMax(char sym1, char sym2)
        {
            return sym1 > sym2 ? sym1 : sym2;
        }
        static string GetMax(string word1, string word2)
        {
            int sum1 = 0;
            foreach (char c in word1)
            {
                sum1 += c;
            }
            int sum2 = 0;
            foreach (char c in word2)
            {
                sum2 += c;
            }

            return sum1 > sum1 ? word1 : word2;
        }
    }
}
