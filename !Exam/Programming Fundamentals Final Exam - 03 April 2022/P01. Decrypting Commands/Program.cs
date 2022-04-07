using System;

namespace P01._Decrypting_Commands
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Finish")
            {
                string[] commandArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string commandType = commandArgs[0];

                if (commandType == "Replace")
                {
                    string currChar = commandArgs[1];
                    string newChar = commandArgs[2];

                    input = input.Replace(currChar, newChar);
                    Console.WriteLine(input);
                }
                else if (commandType == "Cut")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);

                    if (IsIndexValid(startIndex, input) && IsIndexValid(endIndex, input))
                    {
                        input = input.Remove(startIndex, endIndex - startIndex + 1);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }
                else if (commandType == "Make")
                {
                    string caseOfLetters = commandArgs[1];
                    if (caseOfLetters == "Upper")
                    {
                        input = input.ToUpper();
                    }
                    else if (caseOfLetters == "Lower")
                    {
                        input = input.ToLower();
                    }

                    Console.WriteLine(input);
                }
                else if (commandType == "Check")
                {
                    string checkStr = commandArgs[1];

                    if (input.Contains(checkStr))
                    {
                        Console.WriteLine($"Message contains {checkStr}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {checkStr}");
                    }
                }
                else if (commandType == "Sum")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);

                    if (IsIndexValid(startIndex, input) && IsIndexValid(endIndex, input))
                    {
                        string substring = input.Substring(startIndex, endIndex - startIndex + 1);

                        int sumOfChars = 0;
                        foreach (char ch in substring)
                        {
                            sumOfChars += ch;
                        }
                        Console.WriteLine(sumOfChars);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }
            }
        }

        static bool IsIndexValid(int index, string input)
        {
            return index >= 0 && index < input.Length;
        }
    }
}
