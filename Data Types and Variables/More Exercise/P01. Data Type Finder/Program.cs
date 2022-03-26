using System;

namespace P01._Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();            

            while (input != "END")
            {
                bool isInt = int.TryParse(input, out int value);
                bool isDouble = double.TryParse(input, out double value1);
                bool isChar = char.TryParse(input, out char value2);
                bool isBool = bool.TryParse(input, out bool value3);
                string dataType = "";

                if (isInt)
                {
                    dataType = "integer";
                }
                else if (isDouble)
                {
                    dataType = "floating point";
                }
                else if (isChar)
                {
                    dataType = "character";
                }
                else if (isBool)
                {
                    dataType = "boolean";
                }
                else
                {
                    dataType = "string";
                }
                Console.WriteLine($"{input} is {dataType} type");

                input = Console.ReadLine();
            }            
        }
    }
}
