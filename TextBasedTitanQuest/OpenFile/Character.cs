using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TextBasedTitanQuest.Game.Player;

namespace TextBasedTitanQuest.OpenFile
{
    class Character
    {
        //count to 10 passes and update score in txt;
        private static int passes = 0;
        public static string CharPath = Environment.CurrentDirectory + @"\Titan quest Game files\Character.txt";
        public static void Create(string Name)
        {
            FileStream create = new FileStream(CharPath, FileMode.CreateNew);
            create.Close();

            using (StreamWriter WriteInfo = new StreamWriter(CharPath))
            {

                WriteInfo.WriteLine("Name : " + Name);
                WriteInfo.WriteLine("Level : " + 1);
                WriteInfo.WriteLine("Health : " + 100);
                WriteInfo.WriteLine("Energy : " + 100);
                WriteInfo.WriteLine("Area : " + 1);
                WriteInfo.WriteLine("Monsters killed : " + 0);
                WriteInfo.WriteLine("Damage : " + 0);
            }
        }
        public static bool HasBeenCreated()
        {
            return File.Exists(CharPath);
        }
        public static void Update()
        {
            if (passes == 10)
            {
                using (StreamWriter write = new StreamWriter(CharPath,false))
                {
                    write.WriteLine("Name : " + Player.Name);
                    write.WriteLine("Level : " + Player.Level);
                    write.WriteLine("Health : " + Player.MaxHealth);
                    write.WriteLine("Energy : " + Player.MaxMana);
                    write.WriteLine("Area : " + Player.Area);
                    write.WriteLine("Monsters killed : " + Player.KilledMonsters);
                    write.WriteLine("Damage : " + Player.Damage);
                }
            }
            else
            passes++;
        }
        public static void LoadStats()
        {
            using (StreamReader read = new StreamReader(CharPath))
            {
                Player.Name = read.ReadLine().Split(' ')[2];
                Player.Level = int.Parse(read.ReadLine().Split(' ')[2]);
                Player.MaxHealth = int.Parse(read.ReadLine().Split(' ')[2]);
                Player.MaxMana = int.Parse(read.ReadLine().Split(' ')[2]);
                Player.Area = int.Parse(read.ReadLine().Split(' ')[2]);
                Player.KilledMonsters = long.Parse(read.ReadLine().Split(' ')[3]);
                Player.Damage = int.Parse(read.ReadLine().Split(' ')[2]);
                
                Player.Health = Player.MaxHealth;
                Player.Mana = Player.MaxMana;
            }
            
        }
    }
    
}
