using System;

namespace P05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            for (char i = (char)startNumber; i <= (char)endNumber; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
