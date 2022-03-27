using System;

namespace P01._The_Imitation_Game
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] cmdArgs = command.Split('|');

                string cmdType = cmdArgs[0];

                if (cmdType == "Move")
                {
                    int count = int.Parse(cmdArgs[1]);

                    string substring = input.Substring(0, count);
                    input = input.Remove(0, count);
                    input = input.Insert(input.Length, substring);
                }
                else if (cmdType == "Insert")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string value = cmdArgs[2];

                    input = input.Insert(index, value);
                }
                else if (cmdType == "ChangeAll")
                {
                    string substring = cmdArgs[1];
                    string replacement = cmdArgs[2];

                    input = input.Replace(substring, replacement);
                }
            }

            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}
