using System;

namespace P01._Data_Types
{
    internal class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            string variableValue = Console.ReadLine();
            Print(type, variableValue);
        }

        static void Print(string type, string value)
        {
            switch (type)
            {
                case "int":
                    const int MultiplayerI = 2;
                    int valueInt = int.Parse(value);
                    Console.WriteLine(ChangeTheValue(valueInt, MultiplayerI));
                    break;
                case "real":
                    const double MultiplyerD = 1.5;
                    double valueDouble = double.Parse(value);
                    Console.WriteLine($"{ChangeTheValue(valueDouble, MultiplyerD):f2}");
                    break;
                case "string":
                    Console.WriteLine($"${value}$");
                    break;
            }
        }
        static int ChangeTheValue(int num, int multiplayer)
        {
            return num * multiplayer;
        }
        static double ChangeTheValue(double num, double multiplayer)
        {
            return num * multiplayer;
        }
    }
}
