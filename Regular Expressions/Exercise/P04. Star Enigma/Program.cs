using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P04._Star_Enigma
{
    internal class Program
    {
        static void Main()
        {
            List<string> attackedPlanet = new List<string>();
            List<string> destroyedPlanet = new List<string>();

            int countOfMessages = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countOfMessages; i++)
            {
                string message = Console.ReadLine();

                string decryptedMessage = GetDecryptedMessage(message);

                string pattern = @"@(?<planet>[A-Za-z]+)[^@\-!:>]*?:\d+[^@\-!:>]*?!(?<attType>A|D)![^@\-!:>]*?->\d+";

                Match attackInfo = Regex.Match(decryptedMessage, pattern);

                if (attackInfo.Success)
                {
                    string planet = attackInfo.Groups["planet"].Value;
                    string attackType = attackInfo.Groups["attType"].Value;

                    switch (attackType)
                    {
                        case "A":
                            attackedPlanet.Add(planet);
                            break;

                        case "D":
                            destroyedPlanet.Add(planet);
                            break;
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanet.Count}");
            foreach (string planet in attackedPlanet.OrderBy(p => p)) 
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanet.Count}");
            foreach (string planet in destroyedPlanet.OrderBy(p => p))
            {
                Console.WriteLine($"-> {planet}");
            }
        }

        static string GetDecryptedMessage(string message)
        {
            string pattern = "[star]";

            int decryptNum = Regex.Matches(message, pattern, RegexOptions.IgnoreCase).Count();

            StringBuilder decryptedMessage = new StringBuilder();

            foreach (char ch in message)
            {
                char currCh = (char)(ch - decryptNum);
                decryptedMessage.Append(currCh);
            }

            return decryptedMessage.ToString();
        }
    }
}
