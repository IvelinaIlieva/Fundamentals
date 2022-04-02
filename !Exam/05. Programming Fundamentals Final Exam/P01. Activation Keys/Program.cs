using System;
using System.Threading.Channels;

namespace P01._Activation_Keys
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string cmd;
            while ((cmd=Console.ReadLine()) != "Generate")
            {
                string[] cmdArgs = cmd.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "Contains")
                {
                    string substring = cmdArgs[1];

                    Console.WriteLine(input.Contains(substring)
                        ? $"{input} contains {substring}"
                        : "Substring not found!");
                }
                else if (cmdType == "Flip")
                {
                    string caseOfSymbols = cmdArgs[1];
                    int startIndex = int.Parse(cmdArgs[2]);
                    int endIndex = int.Parse(cmdArgs[3]);

                    string replacement = string.Empty;

                    if (caseOfSymbols == "Upper")
                    {
                        replacement = input.Substring(startIndex, endIndex - startIndex).ToUpper();
                    }
                    else if (caseOfSymbols == "Lower")
                    {
                        replacement = input.Substring(startIndex, endIndex - startIndex).ToLower();
                    }

                    input = input.Replace(input.Substring(startIndex, endIndex - startIndex), replacement);
                    Console.WriteLine(input);
                }
                else if (cmdType == "Slice")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    input = input.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(input);
                }
            }

            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}
