using System;

namespace P01._Secret_Chat
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string cmd;
            while ((cmd = Console.ReadLine()) != "Reveal")
            {
                string[] cmdArgs = cmd.Split(":|:");

                string cmdType = cmdArgs[0];
                if (cmdType == "InsertSpace")
                {
                    int index = int.Parse(cmdArgs[1]);
                    input = input.Insert(index, " ");
                }
                else if (cmdType == "Reverse")
                {
                    string substring = cmdArgs[1];
                    if (!input.Contains(substring))
                    {
                        Console.WriteLine("error");
                        continue;
                    }

                    input = input.Remove(input.IndexOf(substring), substring.Length);

                    char[] reversedStrCharArray = substring.ToCharArray();
                    Array.Reverse(reversedStrCharArray);
                    string reversedStr = new string(reversedStrCharArray);

                    input = input.Insert(input.Length, reversedStr);
                }
                else if (cmdType == "ChangeAll")
                {
                    string substring = cmdArgs[1];
                    string replacement = cmdArgs[2];

                    input = input.Replace(substring, replacement);
                }

                Console.WriteLine(input);
            }

            Console.WriteLine($"You have a new text message: {input}");
        }
    }
}
