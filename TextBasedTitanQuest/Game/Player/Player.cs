using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace TextBasedTitanQuest.Game.Player
{
    class Player
    {
        public static string Name;
        public static int Area;

        public static int Health;
        public static int MaxHealth;

        public static int Mana;
        public static int MaxMana;

        public static int Level;
        public static long KilledMonsters;

        public static int Damage;
        public static void Recover()
        {
            if (Health <= MaxHealth / 2)
            {
                int RecoveryTime = MaxHealth / Health;
                Console.WriteLine("Recovering for health {0} seconds",RecoveryTime);
                Thread.Sleep(RecoveryTime * 500);
                Health = MaxHealth;
            }
            if (Mana <= MaxMana / 2)
            {
                int RecoveryTime = MaxMana / Mana;
                Console.WriteLine("Recovering mana for {0} seconds", RecoveryTime);
                Thread.Sleep(RecoveryTime * 500);
                Mana = MaxMana;
            }
        }

        public static void Battle()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Name  :{0} \t Health:{1}/{2}",Name,Health,MaxHealth);
            Console.WriteLine("Level :{0} \t Mana:{1}/{2}",Level,Mana,MaxMana);
            Console.WriteLine("Damage :{0} \t Monsters Killed:{1}",Damage,KilledMonsters);

            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("The {0} {1} of {2}", Monster.Monster.prefix[new Random().Next(0,Monster.Monster.prefix.Count())]
                , Monster.Monster.mainName[new Random().Next(0, Monster.Monster.mainName.Count())]
                , Monster.Monster.suffix[new Random().Next(0, Monster.Monster.suffix.Count())]);
            Console.WriteLine("Level :{0} Health :{1} Damage :{2}", Monster.Monster.Level,Monster.Monster.Health,Monster.Monster.Damage);
            Console.WriteLine("\n\n\n");

            if (Monster.Monster.Health - Damage <= 0)
            {
                KilledMonsters += 1;
            }
            if (Monster.Monster.Damage >= Health)
            {
                Console.WriteLine("Monster killed you " + Name);
            }
            else
            {
                Health -= Monster.Monster.Damage;
            }

            if (new Random().Next(0,10) == 5)
            {
                Level += (int)KilledMonsters / 15;
                Damage += Level;
                MaxHealth += Level / 6;
                MaxMana += Level / 6;
                Area = Level / 5;
            }
        }
    }
}
