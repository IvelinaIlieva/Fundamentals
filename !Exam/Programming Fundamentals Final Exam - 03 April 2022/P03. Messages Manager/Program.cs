using System;
using System.Collections.Generic;

namespace P03._Messages_Manager
{
    internal class Program
    {
        static void Main()
        {
            int a = 5;
            int c = ++a;
            Console.WriteLine(c);

            //            int capacity = int.Parse(Console.ReadLine());

            //            Dictionary<string,int> senders = new Dictionary<string,int>();
            //            Dictionary<string,int> receivers = new Dictionary<string,int>();

            //            string command;
            //            while ((command = Console.ReadLine()) != "Statistics")
            //            {
            //                string[] commandArgs = command.Split('=', StringSplitOptions.RemoveEmptyEntries);

            //                string commandType = commandArgs[0];

            //                if (commandType == "Add")
            //                {
            //                    string username = commandArgs[1];
            //                    int sentMessages = int.Parse(commandArgs[2]);
            //                    int receivedMessages = int.Parse(commandArgs[3]);

            //                    if (!senders.ContainsKey(username))
            //                    {
            //                        senders[username] = sentMessages;
            //                        receivers[username] = receivedMessages;
            //                    }
            //                }
            //                else if (commandType == "Message")
            //                {
            //                    string sender = commandArgs[1];
            //                    string receiver = commandArgs[2];

            //                    if (senders.ContainsKey(sender) && receivers.ContainsKey(receiver))
            //                    {
            //                        senders[sender]++;
            //                        receivers[receiver]++;

            //                        IsReachTheCapacity(senders, receivers, capacity, sender);
            //                        IsReachTheCapacity(senders, receivers, capacity, receiver);
            //                    }
            //                }
            //                else if (commandType == "Empty")
            //                {
            //                    string username = commandArgs[1];

            //                    if (username == "All")
            //                    {
            //                        senders.Clear();
            //                        receivers.Clear();
            //                        continue;
            //                    }

            //                    if (senders.ContainsKey(username))
            //                    {
            //                        senders.Remove(username);
            //                        receivers.Remove(username);
            //                    }
            //                }
            //            }

            //            Console.WriteLine($"Users count: {senders.Count}");

            //            foreach (var kvp in senders)
            //            {
            //                string user = kvp.Key;
            //                int countOfMessages = kvp.Value + receivers[kvp.Key];

            //                Console.WriteLine($"{user} - {countOfMessages}");
            //            }
            //        }

            //        static void IsReachTheCapacity(Dictionary<string, int> senders, Dictionary<string, int> receivers, int capacity, string user)
            //        {
            //            if (senders[user] == capacity)
            //            {
            //                Console.WriteLine($"{user} reached the capacity!");
            //                senders.Remove(user);
            //                receivers.Remove(user);
            //                return;
            //            }

            //            if (receivers[user] == capacity)
            //            {
            //                Console.WriteLine($"{user} reached the capacity!");
            //                senders.Remove(user);
            //                receivers.Remove(user);
            //                return;
            //            }

            //            if (senders[user] + receivers[user] == capacity)
            //            {
            //                Console.WriteLine($"{user} reached the capacity!");
            //                senders.Remove(user);
            //                receivers.Remove(user);
            //                return;
            //            }
        }
    }
}
