using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedTitanQuest.Game.Monster
{
    class Monster
    {
        //"the great     troll      of plovdiv
        //lvl:60            hlth:1000        dmg:100

        //prefix
        public static string[] prefix = {
                              "great", 
                              "greater",
                              "greatest",
                              "powerfull",
                              "stoic",
                              "electric",
                              "burning",
                              "quick",
                              " "
                          };
        //main name
        public static string[] mainName = {
                                       "troll",
                                       "scorpion",
                                       "snake",
                                       "cat",
                                       "harpy",
                                       "gorgon",
                                       "beast"
                                   };
        //of + suffix
        public static string[] suffix = {
                                   "anger",
                                   "patience",
                                   "leeching",
                                   "casting"
                               };
        public static void Update()
        {
            Level = Player.Player.Area + (Player.Player.Level / 2) + new Random().Next(0, 5);
            Health = Level * 3 + Player.Player.Level + Player.Player.Area;
            Damage = Level * 3 + Player.Player.Level + Player.Player.Area;
        }
        public static int Level;
        public static int Health;
        public static int Damage;
    }
}
