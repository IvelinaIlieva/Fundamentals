using System;
using System.Linq;
using System.Text;

namespace P03._Treasure_Finder
{
    internal class Program
    {
        static void Main()
        {
            int[] keys = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(x => int.Parse(x))
                 .ToArray();
            
            string command;
            while ((command = Console.ReadLine()) != "find")
            {
                string input = command;

                StringBuilder output = new StringBuilder();

                int keyIndex = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    char newChar = (char)(input[i] - keys[keyIndex]);
                    output.Append(newChar);
                    keyIndex++;

                    if (keyIndex == keys.Length)
                    {
                        keyIndex = 0;
                    }
                }

                string password = output.ToString();
                string typeOfTreasure = password.Substring(password.IndexOf('&') + 1, password.LastIndexOf('&') - (password.IndexOf('&') + 1));
                string coordinates = password.Substring(password.IndexOf('<') + 1, password.IndexOf('>') -(password.IndexOf('<') + 1));

                Console.WriteLine($"Found {typeOfTreasure} at {coordinates}");
            }
        }
    }
}
