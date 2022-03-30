using System;

namespace P01._World_Tour
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string cmd;
            while ((cmd = Console.ReadLine()) != "Travel")
            {
                string[] cmdAgrs = cmd.Split(':');

                string cmdType = cmdAgrs[0];

                if (cmdType == "Add Stop")
                {
                    int index = int.Parse(cmdAgrs[1]);
                    string substring = cmdAgrs[2];

                    if (IsValid(index, input))
                    {
                        input = input.Insert(index, substring);
                    }
                }
                else if (cmdType == "Remove Stop")
                {
                    int startIndex = int.Parse(cmdAgrs[1]);
                    int endIndex = int.Parse(cmdAgrs[2]);

                    if (IsValid(startIndex, input) && IsValid(endIndex, input))
                    {
                        input = input.Remove(startIndex, endIndex - startIndex + 1);
                    }
                }
                else if (cmdType == "Switch")
                {
                    string oldString = cmdAgrs[1];
                    string newString = cmdAgrs[2];

                    if (input.Contains(oldString))
                    {
                        input = input.Replace(oldString, newString);
                    }
                }

                Console.WriteLine(input);
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }

        static bool IsValid(int index, string input)
        {
            return index >= 0 && index < input.Length;
        }
    }
}
