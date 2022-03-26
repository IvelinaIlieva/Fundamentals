using System;
using System.Collections.Generic;

namespace P05._SoftUni_Parking
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string,string> userInfo = new Dictionary<string,string>();

            int numOfCommands = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numOfCommands; i++)
            {
                string[] commArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string typeOfComd = commArgs[0];
                string username = commArgs[1];

                if (typeOfComd == "register")
                {
                    string licensePlateNumber = commArgs[2];

                    if (!userInfo.ContainsKey(username))
                    {
                        userInfo[username] = licensePlateNumber;
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {userInfo[username]}");
                    }
                }
                else if (typeOfComd == "unregister")
                {
                    if (!userInfo.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        userInfo.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var user in userInfo)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
