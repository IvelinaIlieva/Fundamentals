using System;

namespace P01._Reverse_Strings
{
    internal class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();

            while (command != "end")
            {
                char[] word = command.ToCharArray();
                Array.Reverse(word);
                string reversedWord = new string(word);

                Console.WriteLine($"{command} = {reversedWord}");

                command = Console.ReadLine();
            }
        }
    }
}
