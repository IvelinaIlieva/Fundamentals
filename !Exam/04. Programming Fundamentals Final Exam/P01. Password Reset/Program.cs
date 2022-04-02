using System;
using System.Linq;

namespace P01._Password_Reset
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string cmd;
            while ((cmd = Console.ReadLine()) != "Done")
            {
                string[] cmdArgs = cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "TakeOdd")
                {
                    input = string.Join("", input.Where((ch, i) => i % 2 != 0));
                }
                else if (cmdType == "Cut")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int length = int.Parse(cmdArgs[2]);

                    string substring = input.Substring(index, length);

                    input = input.Remove(input.IndexOf(substring), length);
                }
                else if (cmdType == "Substitute")
                {
                    string substring = cmdArgs[1];
                    string substitute = cmdArgs[2];

                    if (!input.Contains(substring))
                    {
                        Console.WriteLine("Nothing to replace!");
                        continue;
                    }

                    input = input.Replace(substring, substitute);
                }

                Console.WriteLine(input);
            }

            Console.WriteLine($"Your password is: {input}");
        }
    }
}
