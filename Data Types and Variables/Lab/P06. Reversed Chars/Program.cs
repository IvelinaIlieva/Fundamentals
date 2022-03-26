using System;

namespace P06._Reversed_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());
            char symbol3 = char.Parse(Console.ReadLine());
            Console.Write($"{symbol3} {symbol2} {symbol1}");
        }
    }
}
