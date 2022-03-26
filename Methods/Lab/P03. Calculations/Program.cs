﻿using System;

namespace P03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    Add(a, b);
                    break;
                case "subtract":
                    Subtract(a, b);
                    break;
                case "multiply":
                    MultiPly(a, b);
                    break;
                case "divide":
                    Divide(a, b);
                    break;
            }
        }
        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void MultiPly(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}
