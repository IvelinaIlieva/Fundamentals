﻿using System;

namespace P08._Town_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            double area = double.Parse(Console.ReadLine());

            Console.WriteLine($"Town {town} has population of {population} and area {area} square km.");
        }
    }
}
