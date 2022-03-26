using System;

namespace P02._MuOnline
{
    internal class Program
    {
        static void Main()
        {
            string[] rooms = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries);

            int health = 100;
            int bitcoins = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] currRoom = rooms[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = currRoom[0];

                if (command == "potion")
                {
                    int potionForHealing = int.Parse(currRoom[1]);

                    if (health + potionForHealing > 100)
                    {
                        int amountHealing = 100 - health;
                        Console.WriteLine($"You healed for {amountHealing} hp.");
                        health = 100;
                    }
                    else
                    {
                        health += potionForHealing;
                        Console.WriteLine($"You healed for {potionForHealing} hp.");
                    }

                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (command == "chest")
                {
                    int coins = int.Parse(currRoom[1]);

                    Console.WriteLine($"You found {coins} bitcoins.");
                    bitcoins += coins;
                }
                else
                {
                    string monster = command;
                    int monsterAttack = int.Parse(currRoom[1]);

                    health -= monsterAttack;

                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
