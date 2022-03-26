using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P05._Nether_Realms
{
    public class Demon
    {
        public Demon(string name, int health, double damage)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
        }
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }
    }
    internal class Program
    {
        static void Main()
        {
            string[] demonsNames = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);    

            List<Demon> demons = new List<Demon>();

            for (int i = 0; i < demonsNames.Length; i++)
            {
                string name = demonsNames[i];
                int health = GetHealth(demonsNames[i]);
                double damage = GetDamage(demonsNames[i]);

                Demon deamon = new Demon(name, health, damage);
                demons.Add(deamon);
            }

            foreach (Demon demon in demons.OrderBy(d => d.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }

        static int GetHealth(string name)
        {
            int health = 0;
            string pattern = @"[^0-9\+\-\*\/\.\, ]";
            
            MatchCollection demonNameLetters = Regex.Matches(name, pattern);
            
            foreach (Match symbol in demonNameLetters)
            {          
                char currChar = char.Parse(symbol.ToString());
                health += currChar;
            }

            return health;
        }
        static double GetDamage(string name)
        {
            double damage = 0;
            string pattern = @"\-?\d+(\.\d+)?";
           
            MatchCollection demonNameDigits = Regex.Matches(name, pattern);
            foreach (Match digits in demonNameDigits)
            {
                damage += double.Parse(digits.ToString());
            }

            foreach (char ch in name)
            {
                if (ch == '*')
                {
                    damage *= 2;
                }
                if (ch == '/')
                {
                    damage /= 2;
                }
            }

            return damage;
        }
    }
}
