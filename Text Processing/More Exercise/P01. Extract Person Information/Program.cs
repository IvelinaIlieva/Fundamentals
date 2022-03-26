using System;

namespace P01._Extract_Person_Information
{
    internal class Program
    {
        static void Main()
        {
            int countOfRows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= countOfRows; i++)
            {
                string input = Console.ReadLine();

                int startIndexName = input.IndexOf('@') + 1;
                int nameLenght = input.IndexOf('|') - startIndexName;
                string name = input.Substring(startIndexName, nameLenght);

                int startIndexAge = input.IndexOf('#') + 1;
                int ageLenght = input.IndexOf('*') - startIndexAge;
                string age = input.Substring(startIndexAge, ageLenght);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
