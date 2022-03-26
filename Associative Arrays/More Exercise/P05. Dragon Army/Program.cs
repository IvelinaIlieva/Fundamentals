using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._Dragon_Army
{
    class Dragon
    {
        public Dragon(string name, int damage, int health, int armor)
        {
            this.Name = name;
            this.Damage = damage;
            this.Health = health;
            this.Armor = armor;
        }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
    }
    internal class Program
    {
        static void Main()
        {
            int damageByDefault = 45;
            int healthByDefault = 250;
            int armorByDefault = 10;

            Dictionary<string, List<Dragon>> dragonSheet = new Dictionary<string, List<Dragon>>();
            //List<Dragon> dragons = new List<Dragon>();

            int countOfDragons = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countOfDragons; i++)
            {
                //{type} {name} {damage} {health} {armor}
                string[] dragonArgs = Console.ReadLine().Split(' ');
                string type = dragonArgs[0];
                string name = dragonArgs[1];
                int damage = TryParse(dragonArgs[2], damageByDefault);
                int health = TryParse(dragonArgs[3], healthByDefault);
                int armor = TryParse(dragonArgs[4], armorByDefault);

                Dragon currDragon = new Dragon(name, damage, health, armor);

                if (!dragonSheet.ContainsKey(type))
                {
                    List<Dragon> dragons = new List<Dragon>();
                    dragonSheet.Add(type, dragons);
                }

                if (dragonSheet[type].Any(x => x.Name == name))
                {
                    Dragon dragonToChange = dragonSheet[type].Find(x => x.Name == name);
                    dragonToChange.Damage = damage;
                    dragonToChange.Health = health;
                    dragonToChange.Armor = armor;
                    continue;
                }

                dragonSheet[type].Add(currDragon);
            }

            foreach (var kvp in dragonSheet)
            {
                double averageDamage = (double)kvp.Value.Average(x => x.Damage);
                double averageHealth = (double)kvp.Value.Average(x => x.Health);
                double averageArmor = (double)kvp.Value.Average(x => x.Armor);

                Console.WriteLine($"{kvp.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (Dragon dr in kvp.Value.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"-{dr.Name} -> damage: {dr.Damage}, health: {dr.Health}, armor: {dr.Armor}");
                }
            }
        }
        static int TryParse(string dragonArgs, int def)
        {
            bool isTrue = int.TryParse(dragonArgs, out int result);

            return isTrue ? result : def;
        }
    }
}
