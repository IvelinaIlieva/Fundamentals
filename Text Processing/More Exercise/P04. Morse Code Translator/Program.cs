using System;
using System.Collections.Generic;
using System.Text;

namespace P04._Morse_Code_Translator
{
    internal class Program
    {
        static void Main()
        {
            string[] morseInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, char> morseDictionary = new Dictionary<string, char>()
            {
                { ".-", 'A'},
                { "-...", 'B'},
                { "-.-.", 'C'},
                { "-..", 'D'},
                { ".", 'E'},
                { "..-.", 'F'},
                { "--.", 'G'},
                { "....", 'H'},
                { "..", 'I'},
                { ".---", 'J'},
                { "-.-", 'K'},
                { ".-..", 'L'},
                { "--", 'M'},
                { "-.", 'N'},
                { "---", 'O'},
                { ".--.", 'P'},
                { "--.-", 'Q'},
                { ".-.", 'R'},
                { "...", 'S'},
                { "-", 'T'},
                { "..-", 'U'},
                { "...-", 'V'},
                { ".--", 'W'},
                { "-..-", 'X'},
                { "-.--", 'Y'},
                { "--..", 'Z'}
            };

            StringBuilder code = new StringBuilder();

            foreach (string str in morseInput)
            {
                if (str == "|")
                {
                    code.Append(' ');
                }

                if (morseDictionary.ContainsKey(str))
                {
                    code.Append(morseDictionary[str]);
                }
            }

            Console.WriteLine(code);
        }
    }
}
