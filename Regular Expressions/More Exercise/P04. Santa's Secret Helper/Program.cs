using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace P04._Santa_s_Secret_Helper
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            List<string> goodChildren = new List<string>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                StringBuilder childInfo = new StringBuilder();

                foreach (char ch in command)
                {
                    char currCh = (char)(ch - number);
                    childInfo.Append(currCh);
                }

                Regex regex = new Regex(@"@(?<name>[A-Za-z]+)[^\@\-\!\:\>]*!(?<behavior>[G|N])!");

                Match match = regex.Match(childInfo.ToString());

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string behavior = match.Groups["behavior"].Value;

                    if (behavior == "G")
                    {
                        goodChildren.Add(name);
                    }
                }
            }

            Console.WriteLine(string.Join("\n", goodChildren));
        }
    }
}
