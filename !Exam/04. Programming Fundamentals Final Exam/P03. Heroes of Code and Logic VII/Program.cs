using System;
using System.Collections.Generic;

namespace P03._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();

            for (int i = 1; i <= count; i++)
            {
                string[] heroesInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = heroesInfo[0];
                int hitPoints = int.Parse(heroesInfo[1]);
                int manaPoints = int.Parse(heroesInfo[2]);

                heroes.Add(name, new List<int>());
                heroes[name].Add(hitPoints);
                heroes[name].Add(manaPoints);
            }

            string cmd;
            while ((cmd = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = cmd.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];
                string name = cmdArgs[1];

                //HP,MP
                if (cmdType == "CastSpell")
                {
                    int mana = int.Parse(cmdArgs[2]);
                    string spell = cmdArgs[3];

                    CastSpell(name, heroes, mana, spell);
                }
                else if (cmdType == "TakeDamage")
                {
                    int damage = int.Parse(cmdArgs[2]);
                    string attacker = cmdArgs[3];

                    TakeDamage(name, heroes, damage, attacker);
                }
                else if (cmdType == "Recharge")
                {
                    int amount = int.Parse(cmdArgs[2]);

                    const int MaxValue = 200;

                    RechargeOrHeal(name, heroes, amount, cmdType, MaxValue);
                }
                else if (cmdType == "Heal")
                {
                    int amount = int.Parse(cmdArgs[2]);

                    const int MaxValue = 100;

                    RechargeOrHeal(name, heroes, amount, cmdType, MaxValue);
                }
            }

            foreach (var kvp in heroes)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine($"  HP: {kvp.Value[0]}");
                Console.WriteLine($"  MP: {kvp.Value[1]}");
            }
        }

        static void CastSpell(string name, Dictionary<string, List<int>> heroes, int mana, string spell)
        {
            int currMP = heroes[name][1];

            if (currMP >= mana)
            {
                currMP -= mana;
                heroes[name][1] = currMP;
                Console.WriteLine($"{name} has successfully cast {spell} and now has {currMP} MP!");
            }
            else
            {
                Console.WriteLine($"{name} does not have enough MP to cast {spell}!");
            }
        }

        static void TakeDamage(string name, Dictionary<string, List<int>> heroes, int damage, string attacker)
        {
            int currHP = heroes[name][0];

            currHP -= damage;

            if (currHP > 0)
            {
                Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {currHP} HP left!");
                heroes[name][0] = currHP;
            }
            else
            {
                Console.WriteLine($"{name} has been killed by {attacker}!");
                heroes.Remove(name);
            }
        }

        static void RechargeOrHeal(string name, Dictionary<string, List<int>> heroes, int amount, string cmdType, int maxValue)
        {
            int current = amount;

            if (cmdType == "Recharge")
            {
                current += heroes[name][1];
            }
            else if (cmdType == "Heal")
            {
                current += heroes[name][0];
            }

            if (current > maxValue)
            {
                if (cmdType == "Recharge")
                {
                    Console.WriteLine($"{name} recharged for {maxValue - heroes[name][1]} MP!");
                    heroes[name][1] = maxValue;
                }
                else if (cmdType == "Heal")
                {
                    Console.WriteLine($"{name} healed for {maxValue - heroes[name][0]} HP!");
                    heroes[name][0] = maxValue;
                }

            }
            else
            {
                if (cmdType == "Recharge")
                {
                    Console.WriteLine($"{name} recharged for {amount} MP!");
                    heroes[name][1] = current;
                }
                else if (cmdType == "Heal")
                {
                    Console.WriteLine($"{name} healed for {amount} HP!");
                    heroes[name][0] = current;
                }
            }
        }
    }
}
