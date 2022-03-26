using System;
using System.Text;

namespace P07._Repeat_String
{
    internal class Program
    {
        static void Main()
        {
            string stringToRepeat = Console.ReadLine();
            int countOfRepeats = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatTheString(stringToRepeat,countOfRepeats));
        }
        static string RepeatTheString(string word, int counts)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < counts; i++)
            {
                result.Append(word);
            }
            return result.ToString();
        }
    }
}
